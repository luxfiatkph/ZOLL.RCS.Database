using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;
using ZOLL.RCS.Database.DataUnitTests;

namespace ZOLL.RCS.Database.DataIntegrationTests
{
    [TestClass]
    public class Asp330CertLimitIntegrationTests : DataIntegrationTestBase<Asp330CertLimit, string, IAsp330CertLimitRepository>
    {
        public Asp330CertLimitIntegrationTests()
        {
            Repository = UnitOfWork.Asp330CertLimits;
            var certLimitDays = Faker.Random.Short(0, 360);
            Entities.AddRange(FakerAsp330.Asp330CertLimitFaker(certLimitDays, 4));
        }

        [TestMethod]
        public void CrudTest()
        {
            CrudTest(nameof(Asp330CertLimit.UnitUnderTest));
        }

        protected override void FindTest()
        {
            // Arrange
            var cutoff = Entities[2].CertLimitDays;

            // Act
            var actual = Repository.Find(x => x.CertLimitDays.Value >= cutoff).ToList();

            // Assert
            Assert.IsTrue(actual.Count >= 2);
        }

        protected override void UpdateTest()
        {
            // Arrange
            var itemId1 = Entities[0].UnitUnderTest;
            var itemId2 = Entities[2].UnitUnderTest;

            // Act
            var item1 = Repository.Get(itemId1);
            var item2 = Repository.Get(itemId2);
            item1.CertLimitDays = Faker.Random.Short(361, 400);
            item2.CertLimitDays = Faker.Random.Short(361, 400);
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
