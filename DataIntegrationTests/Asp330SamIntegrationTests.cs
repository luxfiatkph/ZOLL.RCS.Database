using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330SamIntegrationTests : DataIntegrationTestBase<Asp330Sam, Guid, IAsp330SamRepository>
    {
        public Asp330SamIntegrationTests()
        {
            Repository = UnitOfWork.Asp330Sams;
            var mins = Faker.Random.Int(1, 1000);
            Entities.AddRange(FakerAsp330.Asp330SamFaker(mins, 4));
        }

        [TestMethod]
        public void CrudTest()
        {
            CrudTest(nameof(Asp330Sam.Asp330TestId));
        }

        protected override void FindTest()
        {
            // Arrange
            var cutoff = Entities[2].MinsOfOp;

            // Act
            var actual = Repository.Find(x => x.MinsOfOp.Value >= cutoff).ToList();

            // Assert
            Assert.IsTrue(actual.Count >= 2);
        }

        protected override void UpdateTest()
        {
            // Arrange
            var itemId1 = Entities[0].Asp330TestId;
            var itemId2 = Entities[2].Asp330TestId;

            // Act
            var item1 = Repository.Get(itemId1);
            var item2 = Repository.Get(itemId2);
            item1.MinsOfOp = Faker.Random.Int(1001, 2000);
            item2.MinsOfOp = Faker.Random.Int(1001, 2000);
            var actual = UnitOfWork.SaveChanges();
            var changedItem1 = Repository.Get(itemId1);
            var changedItem2 = Repository.Get(itemId2);

            // Assert
            Assert.AreEqual(2, actual);
            Assert.IsTrue(item1.Equals(changedItem1));
            Assert.IsTrue(item2.Equals(changedItem2));
        }
    }

}