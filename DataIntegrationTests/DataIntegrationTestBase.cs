using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public abstract class DataIntegrationTestBase<TEntity, TKey, TRepository>
    where TEntity : class
    where TRepository : IRepository<TEntity, TKey>
    {
        protected const int ListCount = 4;
        protected IUnitOfWork UnitOfWork { get; }
        protected Faker Faker { get; }
        protected List<TEntity> Entities { get; }
        protected TRepository Repository { get; set; }

        protected DataIntegrationTestBase()
        {
            UnitOfWork = new UnitOfWork(new TceContext());
            Faker = new Faker();
            Entities = new List<TEntity>();
        }

        [TestMethod]
        public void CrudTest(string keyPropertyName)
        {
            try
            {
                CreateTest();
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

        protected void CreateTest()
        {
            // Arrange
            var itemToAdd = Entities[0];
            var listToAdd = Entities.GetRange(1, 3);
            const int expected = ListCount;

            // Act
            Repository.Add(itemToAdd);
            Repository.AddRange(listToAdd);
            var actual = UnitOfWork.SaveChanges();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        protected void ReadItemTest(string propertyName)
        {
            // Arrange
            var itemToRead = (TEntity)Activator.CreateInstance(typeof(TEntity), Entities[0]);
            var valueToMatch = typeof(TEntity).GetProperty(propertyName)?.GetValue(itemToRead);
            var key = (TKey)valueToMatch;

            // Act
            var itemRead = Repository.Get(key);

            // Assert
            Assert.IsTrue(itemToRead.Equals(itemRead));
        }

        protected void ReadAllTest()
        {
            // Arrange

            // Act
            var items = Repository.GetAll();

            // Assert
            var readItems = items.ToList();
            Assert.IsTrue(readItems.Count >= ListCount);
            for (var i = 0; i < ListCount; i++)
            {
                Assert.IsTrue(readItems.Contains(Entities[i]));
            }
        }

        protected abstract void FindTest();

        protected abstract void UpdateTest();

        protected void DeleteItemTest(string propertyName)
        {
            // Arrange
            var item = Entities[0];
            var valueToMatch = typeof(TEntity).GetProperty(propertyName)?.GetValue(item);

            // Act
            Repository.Remove(item);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = Repository.GetAll().ToList();
            var found = false;
            foreach (var remainingItem in remainingItems)
            {
                var value = typeof(TEntity).GetProperty(propertyName)?.GetValue(remainingItem);
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
            var itemsToDelete = Entities.GetRange(1, 2);
            var valueToMatch1 = typeof(TEntity).GetProperty(propertyName)?.GetValue(Entities[1]);
            var valueToMatch2 = typeof(TEntity).GetProperty(propertyName)?.GetValue(Entities[2]);
            var valueToMatch3 = typeof(TEntity).GetProperty(propertyName)?.GetValue(Entities[3]);

            // Act
            Repository.RemoveRange(itemsToDelete);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = Repository.GetAll().ToList();
            var found1 = false;
            var found2 = false;
            var found3 = false;
            foreach (var remainingItem in remainingItems)
            {
                var value = typeof(TEntity).GetProperty(propertyName)?.GetValue(remainingItem);
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
                var itemFound = Repository.Get(key);
                if (itemFound == null) continue;
                removedItems.Add(itemFound);
                Repository.Remove(itemFound);
            }

            if (removedItems.Count > 0) UnitOfWork.SaveChanges();

            UnitOfWork.Dispose();
        }
    }
}