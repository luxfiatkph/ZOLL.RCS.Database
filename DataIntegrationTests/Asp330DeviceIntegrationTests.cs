using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330DeviceIntegrationTests : DataIntegrationTestBase<Asp330Device, Guid, IAsp330DeviceRepository>
    {
        public Asp330DeviceIntegrationTests()
        {
            Repository = UnitOfWork.Asp330Devices;
            var lcdContrast = Faker.Random.Int(0, 500);
            Entities.AddRange(FakerAsp330.Asp330DeviceFaker(lcdContrast, 4));
        }

        [TestMethod]
        public void CrudTest()
        {
            CrudTest(nameof(Asp330Device.Asp330TestId));
        }

        protected override void FindTest()
        {
            // Arrange
            var cutoff = Entities[2].LcdContrast;

            // Act
            var actual = Repository.Find(x => x.LcdContrast.Value >= cutoff).ToList();

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
            item1.LcdContrast = Faker.Random.Int(501, 600);
            item2.LcdContrast = Faker.Random.Int(501, 600);
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