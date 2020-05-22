using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public abstract class DataIntegrationSubItemTestBase<TEntity, TSubEntity, TKey, TItemRepository, TSubItemRepository>
        where TEntity : class
        where TSubEntity : class
        where TItemRepository : IRepository<TEntity, TKey>
        where TSubItemRepository : IRepository<TSubEntity, TKey>
    {
        protected const int ListCount = 4;
        protected const int EntityCount = 1;
        protected IUnitOfWork UnitOfWork { get; }
        protected List<TEntity> Entities { get; set; }
        protected List<TSubEntity> SubEntities { get; set; }
        protected TItemRepository ItemRepository { get; set; }
        protected TSubItemRepository SubItemRepository { get; set; }

        protected DataIntegrationSubItemTestBase()
        {
            UnitOfWork = new UnitOfWork(new TceContext());
        }

        [TestMethod]
        public void CrudTest(string keyPropertyName)
        {
            try
            {
                LoadEntities();

                CreateItemTest();
                CreateItemsTest();
                ReadItemTest(keyPropertyName);
                ReadAllTest();
                FindTest();
                UpdateTest();
                DeleteItemTest(keyPropertyName);
                DeleteRangeTest(keyPropertyName);
            }
            finally
            {
                Cleanup(keyPropertyName);
            }
        }

        protected void LoadEntities()
        {
            ItemRepository.AddRange(Entities);
            UnitOfWork.SaveChanges();
        }

        protected void CreateItemTest()
        {
            // Arrange
            var itemToAdd = SubEntities[0];

            // Act
            SubItemRepository.Add(itemToAdd);
            var actual = UnitOfWork.SaveChanges();

            // Assert
            Assert.AreEqual(EntityCount, actual);
        }

        protected void CreateItemsTest()
        {
            // Arrange
            var listToAdd = SubEntities.GetRange(1, 3);

            // Act
            SubItemRepository.AddRange(listToAdd);
            var actual = UnitOfWork.SaveChanges();

            // Assert
            Assert.AreEqual(EntityCount * 3, actual);
        }

        protected void ReadItemTest(string propertyName)
        {
            // Arrange
            var itemToRead = (TSubEntity)Activator.CreateInstance(typeof(TSubEntity), SubEntities[0]);
            var valueToMatch = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(itemToRead);
            var key = (TKey)valueToMatch;

            // Act
            var itemRead = SubItemRepository.Get(key);

            // Assert
            Assert.IsTrue(itemToRead.Equals(itemRead));
        }

        protected void ReadAllTest()
        {
            // Arrange

            // Act
            var items = SubItemRepository.GetAll();

            // Assert
            var readItems = items.ToList();
            Assert.IsTrue(readItems.Count >= ListCount);
            for (var i = 0; i < ListCount; i++)
            {
                Assert.IsTrue(readItems.Contains(SubEntities[i]));
            }
        }

        protected abstract void FindTest();

        protected abstract void UpdateTest();

        protected void DeleteItemTest(string propertyName)
        {
            // Arrange
            var item = SubEntities[0];
            var valueToMatch = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(item);

            // Act
            SubItemRepository.Remove(item);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = SubItemRepository.GetAll().ToList();
            var found = false;
            foreach (var remainingItem in remainingItems)
            {
                var value = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(remainingItem);
                if (value != null && value.Equals(valueToMatch))
                {
                    found = true;
                    break;
                }
            }

            // Assert
            Assert.AreEqual(1, actual);
            Assert.IsFalse(found);
        }

        protected void DeleteRangeTest(string propertyName)
        {
            // Arrange
            var itemsToDelete = SubEntities.GetRange(1, 2);
            var valueToMatch1 = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(SubEntities[1]);
            var valueToMatch2 = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(SubEntities[2]);
            var valueToMatch3 = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(SubEntities[3]);

            // Act
            SubItemRepository.RemoveRange(itemsToDelete);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = SubItemRepository.GetAll().ToList();
            var found1 = false;
            var found2 = false;
            var found3 = false;
            foreach (var remainingItem in remainingItems)
            {
                var value = typeof(TSubEntity).GetProperty(propertyName)?.GetValue(remainingItem);
                if (value != null && value.Equals(valueToMatch1)) found1 = true;
                if (value != null && value.Equals(valueToMatch2)) found2 = true;
                if (value != null && value.Equals(valueToMatch3)) found3 = true;
            }

            // Assert
            Assert.AreEqual(2, actual);
            Assert.IsFalse(found1);
            Assert.IsFalse(found2);
            Assert.IsTrue(found3);
        }


        protected void Cleanup(string propertyName)
        {
            // clean up any stragglers
            var removedItems = new List<TEntity>();
            foreach (var item in Entities)
            {
                var valueToMatch = typeof(TEntity).GetProperty(propertyName)?.GetValue(item);
                var key = (TKey)valueToMatch;
                var itemFound = ItemRepository.Get(key);
                if (itemFound == null) continue;
                removedItems.Add(itemFound);
                ItemRepository.Remove(itemFound);
            }

            if (removedItems.Count > 0) UnitOfWork.SaveChanges();

            UnitOfWork.Dispose();
        }
    }

}