using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330CustomerCertIntegrationTests : DataIntegrationTestBase<Asp330CustomerCert, Guid, IAsp330CustomerCertRepository>
    {
        public Asp330CustomerCertIntegrationTests()
        {
            Repository = UnitOfWork.Asp330CustomerCerts;
            var date = Faker.Date.Future();
            Entities.AddRange(FakerAsp330.Asp330CustomerCertFaker(date, 4));
        }

        [TestMethod]
        public void CrudTest()
        {
            CrudTest(nameof(Asp330CustomerCert.Asp330CustomerCertId));
        }

        protected override void FindTest()
        {
            // Arrange
            var cutoff = Entities[2].SystemTestDate;

            // Act
            var actual = Repository.Find(x => x.SystemTestDate.Value >= cutoff).ToList();

            // Assert
            Assert.IsTrue(actual.Count >= 2);
        }

        protected override void UpdateTest()
        {
            // Arrange
            var itemId1 = Entities[0].Asp330CustomerCertId;
            var itemId2 = Entities[2].Asp330CustomerCertId;

            // Act
            var item1 = Repository.Get(itemId1);
            var item2 = Repository.Get(itemId2);
            item1.PmDueDate = Faker.Date.Future(2);
            item2.PmDueDate = Faker.Date.Future(2);
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