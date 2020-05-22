using System.Collections.Generic;
using System.Linq;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330SequenceTestIntegrationTests
    {
        protected const int ListCount = 4;
        protected IUnitOfWork UnitOfWork { get; }
        protected Faker Faker { get; }
        protected List<Asp330SequenceTest> Entities { get; }
        protected IAsp330SequenceTestRepository Repository { get; set; }
        public Asp330SequenceTestIntegrationTests()
        {
            Faker = new Faker();
            Entities = new List<Asp330SequenceTest>();
            UnitOfWork = new UnitOfWork(new TceContext());
            Repository = UnitOfWork.Asp330SequenceTests;
            var sequenceId = Faker.Random.Short(1, 500);
            var testId = Faker.Random.Short(1, 500);
            Entities.AddRange(FakerAsp330.Asp330SequenceTestFaker(sequenceId, testId, ListCount));
            sequenceId = Faker.Random.Short(1, 500);
            testId = Faker.Random.Short(1, 500);
            Entities.AddRange(FakerAsp330.Asp330SequenceTestFaker(sequenceId, testId, ListCount));
        }

        [TestMethod]
        public void CrudTest()
        {
            try
            {
                CreateTest();
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

        protected void CreateTest()
        {
            // Arrange
            var itemToAdd = Entities[0];
            var listToAdd = Entities.GetRange(1, 7);
            const int expected = ListCount * 2;

            // Act
            Repository.Add(itemToAdd);
            Repository.AddRange(listToAdd);
            var actual = UnitOfWork.SaveChanges();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        protected void ReadItemTest()
        {
            // Arrange
            var itemToRead = new Asp330SequenceTest(Entities[Faker.Random.Int(0, 7)]);
            var sequenceId = itemToRead.SequenceId;
            var testId = itemToRead.TestId;

            // Act
            var itemRead = Repository.Get(sequenceId, testId);

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
            Assert.IsTrue(readItems.Count >= ListCount * 2);
            for (var i = 0; i < ListCount * 2; i++)
            {
                Assert.IsTrue(readItems.Contains(Entities[i]));
            }
        }

        protected void FindTest()
        {
            // Arrange
            var cutoff = Entities[2].TestId;
            var sequenceId = Entities[2].SequenceId;

            // Act
            var actual = Repository.Find(x => x.SequenceId == sequenceId && x.TestId >= cutoff).OfType<Asp330SequenceTest>().ToList();

            // Assert
            Assert.IsTrue(actual.Count() >= 2);
        }

        protected void UpdateTest()
        {
            // Arrange
            var sequenceId1 = Entities[0].SequenceId;
            var testId1 = Entities[0].TestId;
            var sequenceId2 = Entities[5].SequenceId;
            var testId2 = Entities[5].TestId;

            // Act
            var item1 = Repository.Get(sequenceId1, testId1);
            var item2 = Repository.Get(sequenceId2, testId2);
            item1.SequenceName = Faker.Random.AlphaNumeric(25);
            item2.SequenceName = Faker.Random.AlphaNumeric(25);
            var actual = UnitOfWork.SaveChanges();
            var changedItem1 = Repository.Get(item1.SequenceId, item1.TestId);
            var changedItem2 = Repository.Get(item2.SequenceId, item2.TestId);

            // Assert
            Assert.AreEqual(2, actual);
            Assert.IsTrue(item1.Equals(changedItem1));
            Assert.IsTrue(item2.Equals(changedItem2));
        }

        protected void DeleteItemTest()
        {
            // Arrange
            var item = Entities[4];
            var sequenceId1 = Entities[4].SequenceId;
            var testId1 = Entities[4].TestId;

            // Act
            Repository.Remove(item);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = Repository.GetAll().ToList();
            var found = false;
            foreach (var remainingItem in remainingItems)
            {
                var foundSeqId = remainingItem.SequenceId;
                var foundTestId = remainingItem.TestId;
                if (foundSeqId.Equals(sequenceId1) && foundTestId.Equals(testId1))
                {
                    found = true;
                    break;
                }
            }

            // Assert
            Assert.AreEqual(1, actual);
            Assert.IsFalse(found);
        }

        protected void DeleteRangeTest()
        {
            // Arrange
            var itemsToDelete = Entities.GetRange(5, 2);
            var sequenceId1 = Entities[5].SequenceId;
            var testId1 = Entities[5].TestId;
            var sequenceId2 = Entities[6].SequenceId;
            var testId2 = Entities[6].TestId;
            var sequenceId3 = Entities[7].SequenceId;
            var testId3 = Entities[7].TestId;

            // Act
            Repository.RemoveRange(itemsToDelete);
            var actual = UnitOfWork.SaveChanges();
            var remainingItems = Repository.GetAll().ToList();
            var found1 = false;
            var found2 = false;
            var found3 = false;
            foreach (var remainingItem in remainingItems)
            {
                if (remainingItem.TestId.Equals(testId1) && remainingItem.SequenceId.Equals(sequenceId1)) found1 = true;
                if (remainingItem.TestId.Equals(testId2) && remainingItem.SequenceId.Equals(sequenceId2)) found2 = true;
                if (remainingItem.TestId.Equals(testId3) && remainingItem.SequenceId.Equals(sequenceId3)) found3 = true;
            }

            // Assert
            Assert.AreEqual(2, actual);
            Assert.IsFalse(found1);
            Assert.IsFalse(found2);
            Assert.IsTrue(found3);
        }

        protected void Cleanup()
        {
            // clean up any stragglers
            var removedItems = new List<Asp330SequenceTest>();
            foreach (var item in Entities)
            {
                var itemFound = Repository.Get(item.SequenceId, item.TestId);
                if (itemFound == null) continue;
                removedItems.Add(itemFound);
                Repository.Remove(itemFound);
            }

            if (removedItems.Count > 0) UnitOfWork.SaveChanges();

            UnitOfWork.Dispose();
        }
    }
}