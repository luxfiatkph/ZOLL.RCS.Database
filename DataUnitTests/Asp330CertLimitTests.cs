using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330CertLimitTests : DataUnitTestBase<Asp330CertLimit>
    {
        public Asp330CertLimitTests()
        {
            Target = FakerAsp330.Asp330CertLimitFaker(Faker.Random.Short(1, 360))[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330CertLimit(Target);
            var entity = new Asp330CertLimit(Target);
            var targetObject = (object)target;

            // Act
            var actual = entity.Equals(targetObject);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Null()
        {
            // Arrange
            var target = new Asp330CertLimit(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330CertLimit(Target);
            var refTarget = target;

            // Act
            var actual = target.Equals(refTarget);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Equal()
        {
            // Arrange
            var entity = new Asp330CertLimit(Target);
            var target = new Asp330CertLimit(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_UnitUnderTest_NE()
        {
            // Arrange
            var target = new Asp330CertLimit(Target);
            var entity = new Asp330CertLimit(Target);
            target.UnitUnderTest = UnitTestHelper.Tweak(Target.UnitUnderTest);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CertLimitDays_NE()
        {
            // Arrange
            var target = new Asp330CertLimit(Target);
            var entity = new Asp330CertLimit(Target);
            target.CertLimitDays = UnitTestHelper.Tweak(Target.CertLimitDays);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}