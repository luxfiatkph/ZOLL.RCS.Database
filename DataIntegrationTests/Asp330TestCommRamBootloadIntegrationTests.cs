using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330TestCommRamBootloadIntegrationTests : DataIntegrationSubItemTestBase<Asp330Test,
        Asp330TestCommRamBootload, Guid, IAsp330TestRepository, IAsp330TestCommRamBootloadRepository>
    {
        public Asp330TestCommRamBootloadIntegrationTests()
        {
            ItemRepository = UnitOfWork.Asp330Tests;
            SubItemRepository = UnitOfWork.Asp330TestCommRamBootloads;
            Entities = FakerAsp330.Asp330TestFaker(ListCount);
            var ids = Entities.Select(testEntity => testEntity.Asp330TestId).ToList();
            SubEntities = FakerAsp330.Asp330TestCommRamBootloadFaker(ids);
        }

        [TestMethod]
        public void CrudTest()
        {
            CrudTest(nameof(Asp330TestBuzzerCheck.Asp330TestId));
        }

        protected override void FindTest()
        {
            // Arrange
            var count = SubEntities.Count(entity => entity.ResultCheckBox.HasValue && entity.ResultCheckBox.Value);

            // Act
            var actual = SubItemRepository.Find(x => x.ResultCheckBox.Value).ToList();

            // Assert
            Assert.IsTrue(actual.Count == count);
        }

        protected override void UpdateTest()
        {
            // Arrange
            var itemId1 = Entities[0].Asp330TestId;
            var itemId2 = Entities[2].Asp330TestId;

            // Act
            var item1 = SubItemRepository.Get(itemId1);
            var item2 = SubItemRepository.Get(itemId2);
            item1.ResultCheckBox = UnitTestHelper.Tweak(item1.ResultCheckBox);
            item2.ResultCheckBox = UnitTestHelper.Tweak(item2.ResultCheckBox);
            var actual = UnitOfWork.SaveChanges();
            var changedItem1 = SubItemRepository.Get(itemId1);
            var changedItem2 = SubItemRepository.Get(itemId2);

            // Assert
            Assert.AreEqual(EntityCount * 2, actual);
            Assert.IsTrue(item1.Equals(changedItem1));
            Assert.IsTrue(item2.Equals(changedItem2));
        }
    }
}