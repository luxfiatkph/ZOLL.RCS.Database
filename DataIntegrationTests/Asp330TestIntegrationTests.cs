using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330TestIntegrationTests
    {
        protected const int ListCount = 4;
        protected const int EntityCount = 9;

        protected IUnitOfWork UnitOfWork { get; }
        protected List<Asp330Test> Entities { get; }
        protected List<Asp330TestAspSelfCheck> Asp330TestAspSelfChecks { get; }
        protected List<Asp330TestButtonCheck> Asp330TestButtonChecks { get; }
        protected List<Asp330TestBuzzerCheck> Asp330TestBuzzerChecks { get; }
        protected List<Asp330TestCommRamBootload> Asp330TestCommRamBootloads { get; }
        protected List<Asp330TestConditionalPmDueReset> Asp330TestConditionalPmDueResets { get; }
        protected List<Asp330TestDatetimeCheck> Asp330TestDatetimeChecks { get; }
        protected List<Asp330TestLcdContrastSet> Asp330TestLcdContrastSets { get; }
        protected List<Asp330TestTotalPowerFailureAlarm> Asp330TestTotalPowerFailureAlarms { get; }

        protected IAsp330TestRepository Repository { get; }

        public Asp330TestIntegrationTests()
        {
            UnitOfWork = new UnitOfWork(new TceContext());
            Repository = UnitOfWork.Asp330Tests;
            Entities = FakerAsp330.Asp330TestFaker(ListCount);

            var ids = Entities.Select(testEntity => testEntity.Asp330TestId).ToList();

            Asp330TestAspSelfChecks = FakerAsp330.Asp330TestAspSelfCheckFaker(ids);
            Asp330TestButtonChecks = FakerAsp330.Asp330TestButtonCheckFaker(ids);
            Asp330TestBuzzerChecks = FakerAsp330.Asp330TestBuzzerCheckFaker(ids);
            Asp330TestCommRamBootloads = FakerAsp330.Asp330TestCommRamBootloadFaker(ids);
            Asp330TestConditionalPmDueResets = FakerAsp330.Asp330TestConditionalPmDueResetFaker(ids);
            Asp330TestDatetimeChecks = FakerAsp330.Asp330TestDatetimeCheckFaker(ids);
            Asp330TestLcdContrastSets = FakerAsp330.Asp330TestLcdContrastSetFaker(ids);
            Asp330TestTotalPowerFailureAlarms = FakerAsp330.Asp330TestTotalPowerFailureAlarmFaker(ids);

            for (var i = 0; i < ListCount; i++)
            {
                Asp330TestAspSelfChecks[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestAspSelfCheck = Asp330TestAspSelfChecks[i];
                Asp330TestButtonChecks[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestButtonCheck = Asp330TestButtonChecks[i];

                Asp330TestBuzzerChecks[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestBuzzerCheck = Asp330TestBuzzerChecks[i];
                Asp330TestCommRamBootloads[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestCommRamBootload = Asp330TestCommRamBootloads[i];

                Asp330TestConditionalPmDueResets[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestConditionalPmDueReset = Asp330TestConditionalPmDueResets[i];
                Asp330TestDatetimeChecks[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestDatetimeCheck = Asp330TestDatetimeChecks[i];

                Asp330TestLcdContrastSets[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestLcdContrastSet = Asp330TestLcdContrastSets[i];
                Asp330TestTotalPowerFailureAlarms[i].Asp330Test = Entities[i];
                Entities[i].Asp330TestTotalPowerFailureAlarm = Asp330TestTotalPowerFailureAlarms[i];
            }
        }

        [TestMethod]
        public void CrudTest()
        {
            try
            {
                CreateItemTest();
                CreateItemsTest();
                ReadItemTest();
                ReadAllTest();
                FindTest();
                UpdateTest();
                DeleteItemTest();
                DeleteRangeTest();
            }
            finally
            {
                Cleanup();
            }
        }

        protected void CreateItemTest()
        {
            // Arrange
            var itemToAdd = Entities[0];

            // Act
            Repository.Add(itemToAdd);
            var actual = UnitOfWork.SaveChanges();

            // Assert
            Assert.AreEqual(EntityCount, actual);
        }

        protected void CreateItemsTest()
        {
            // Arrange
            var listToAdd = Entities.GetRange(1, 3);

            // Act
            Repository.AddRange(listToAdd);
            var actual = UnitOfWork.SaveChanges();

            // Assert
            Assert.AreEqual(EntityCount * 3, actual);
        }

        protected void ReadItemTest()
        {
            // Arrange
            var itemToRead = Entities[0];
            var key = itemToRead.Asp330TestId;

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

        protected void FindTest()
        {
            // Arrange
            var count = Entities.Count(entity => entity.ResultCheckBox.HasValue && entity.ResultCheckBox.Value);

            // Act
            var actual = Repository.Find(x => x.ResultCheckBox.Value).ToList();

            // Assert
            Assert.IsTrue(actual.Count == count);
        }

        protected void UpdateTest()
        {
            // Arrange
            var itemId1 = Entities[0].Asp330TestId;
            var itemId2 = Entities[2].Asp330TestId;

            // Act
            var item1 = Repository.Get(itemId1);
            var item2 = Repository.Get(itemId2);
            item1.ResultCheckBox = UnitTestHelper.Tweak(item1.ResultCheckBox);
            item2.ResultCheckBox = UnitTestHelper.Tweak(item2.ResultCheckBox);
            item1.Asp330TestAspSelfCheck.PassedCommSelfCheck = UnitTestHelper.Tweak(item1.Asp330TestAspSelfCheck.PassedCommSelfCheck);
            item2.Asp330TestAspSelfCheck.PassedCommSelfCheck = UnitTestHelper.Tweak(item2.Asp330TestAspSelfCheck.PassedCommSelfCheck);
            item1.Asp330TestButtonCheck.CheckPassedCassButton = UnitTestHelper.Tweak(item1.Asp330TestButtonCheck.CheckPassedCassButton);
            item2.Asp330TestButtonCheck.CheckPassedCassButton = UnitTestHelper.Tweak(item2.Asp330TestButtonCheck.CheckPassedCassButton);

            item1.Asp330TestBuzzerCheck.ResultCheckBox = UnitTestHelper.Tweak(item1.Asp330TestBuzzerCheck.ResultCheckBox);
            item2.Asp330TestBuzzerCheck.ResultCheckBox = UnitTestHelper.Tweak(item2.Asp330TestBuzzerCheck.ResultCheckBox);
            item1.Asp330TestCommRamBootload.ResultCheckBox = UnitTestHelper.Tweak(item1.Asp330TestCommRamBootload.ResultCheckBox);
            item2.Asp330TestCommRamBootload.ResultCheckBox = UnitTestHelper.Tweak(item2.Asp330TestCommRamBootload.ResultCheckBox);

            item1.Asp330TestConditionalPmDueReset.ResultCheckBox = UnitTestHelper.Tweak(item1.Asp330TestConditionalPmDueReset.ResultCheckBox);
            item2.Asp330TestConditionalPmDueReset.ResultCheckBox = UnitTestHelper.Tweak(item2.Asp330TestConditionalPmDueReset.ResultCheckBox);
            item1.Asp330TestDatetimeCheck.ResultCheckBox = UnitTestHelper.Tweak(item1.Asp330TestDatetimeCheck.ResultCheckBox);
            item2.Asp330TestDatetimeCheck.ResultCheckBox = UnitTestHelper.Tweak(item2.Asp330TestDatetimeCheck.ResultCheckBox);

            item1.Asp330TestLcdContrastSet.ResultCheckBox = UnitTestHelper.Tweak(item1.Asp330TestLcdContrastSet.ResultCheckBox);
            item2.Asp330TestLcdContrastSet.ResultCheckBox = UnitTestHelper.Tweak(item2.Asp330TestLcdContrastSet.ResultCheckBox);
            item1.Asp330TestTotalPowerFailureAlarm.ResultCheckBox = UnitTestHelper.Tweak(item1.Asp330TestTotalPowerFailureAlarm.ResultCheckBox);
            item2.Asp330TestTotalPowerFailureAlarm.ResultCheckBox = UnitTestHelper.Tweak(item2.Asp330TestTotalPowerFailureAlarm.ResultCheckBox);

            var actual = UnitOfWork.SaveChanges();
            var changedItem1 = Repository.Get(itemId1);
            var changedItem2 = Repository.Get(itemId2);

            // Assert
            Assert.AreEqual(EntityCount * 2, actual);
            Assert.IsTrue(item1.Equals(changedItem1));
            Assert.IsTrue(item2.Equals(changedItem2));
        }

        protected void DeleteItemTest()
        {
            // Arrange
            var item = Entities[0];
            var valueToMatch = item.Asp330TestId;

            // Act
            Repository.Remove(item);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = Repository.GetAll().ToList();
            var found = false;
            foreach (var remainingItem in remainingItems)
            {
                var value = remainingItem.Asp330TestId;
                if (value.Equals(valueToMatch))
                {
                    found = true;
                    break;
                }
            }

            // Assert
            Assert.AreEqual(EntityCount, actual);
            Assert.IsFalse(found);
        }

        protected void DeleteRangeTest()
        {
            // Arrange
            var itemsToDelete = Entities.GetRange(1, 2);
            var valueToMatch1 = Entities[1].Asp330TestId;
            var valueToMatch2 = Entities[2].Asp330TestId;
            var valueToMatch3 = Entities[3].Asp330TestId;

            // Act
            Repository.RemoveRange(itemsToDelete);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = Repository.GetAll().ToList();
            var found1 = false;
            var found2 = false;
            var found3 = false;
            foreach (var remainingItem in remainingItems)
            {
                var value = remainingItem.Asp330TestId;
                if (value.Equals(valueToMatch1)) found1 = true;
                if (value.Equals(valueToMatch2)) found2 = true;
                if (value.Equals(valueToMatch3)) found3 = true;
            }

            // Assert
            Assert.AreEqual(EntityCount * 2, actual);
            Assert.IsFalse(found1);
            Assert.IsFalse(found2);
            Assert.IsTrue(found3);
        }

        protected void Cleanup()
        {
            // clean up any stragglers
            var removedItems = new List<Asp330Test>();
            foreach (var item in Entities)
            {
                var itemFound = Repository.Get(item.Asp330TestId);
                if (itemFound == null) continue;
                removedItems.Add(itemFound);
                Repository.Remove(itemFound);
            }

            if (removedItems.Count > 0) UnitOfWork.SaveChanges();

            UnitOfWork.Dispose();
        }
    }
}