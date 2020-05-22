using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330TestTotalPowerFailureAlarmIntegrationTests : DataIntegrationSubItemTestBase<Asp330Test,
        Asp330TestTotalPowerFailureAlarm, Guid, IAsp330TestRepository, IAsp330TestTotalPowerFailureAlarmRepository>
    {
        public Asp330TestTotalPowerFailureAlarmIntegrationTests()
        {
            ItemRepository = UnitOfWork.Asp330Tests;
            SubItemRepository = UnitOfWork.Asp330TestTotalPowerFailureAlarms;
            Entities = FakerAsp330.Asp330TestFaker(ListCount);
            var ids = Entities.Select(testEntity => testEntity.Asp330TestId).ToList();
            SubEntities = FakerAsp330.Asp330TestTotalPowerFailureAlarmFaker(ids);
        }

        [TestMethod]
        public void CrudTest()
        {
            CrudTest(nameof(Asp330TestTotalPowerFailureAlarm.Asp330TestId));
        }

        [TestMethod]
        protected override void FindTest()
        {
            // Arrange
            var count = SubEntities.Count(entity => entity.ResultCheckBox.HasValue && entity.ResultCheckBox.Value);

            // Act
            var actual = SubItemRepository.Find(x => x.ResultCheckBox.Value).ToList();

            // Assert
            Assert.IsTrue(actual.Count == count);
        }

        [TestMethod]
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