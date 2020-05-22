using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330CustomerCertTests : DataUnitTestBase<Asp330CustomerCert>
    {
        public Asp330CustomerCertTests()
        {
            Target = FakerAsp330.Asp330CustomerCertFaker(Faker.Date.Future())[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330CustomerCert(Target);
            var entity = new Asp330CustomerCert(Target);
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
            var target = new Asp330CustomerCert(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330CustomerCert(Target);
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
            var target = new Asp330CustomerCert(Target);
            var entity = new Asp330CustomerCert(Target);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330CustomerCertId_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.Asp330CustomerCertId = UnitTestHelper.Tweak(Target.Asp330CustomerCertId);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_RcmId_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.RcmId = UnitTestHelper.Tweak(Target.RcmId);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330SystemTestId_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.Asp330SystemTestId = UnitTestHelper.Tweak(Target.Asp330SystemTestId);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330FinalConfigId_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.Asp330FinalConfigId = UnitTestHelper.Tweak(Target.Asp330FinalConfigId);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330Sn_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.Asp330Sn = UnitTestHelper.Tweak(Target.Asp330Sn);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330Model_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.Asp330Model = UnitTestHelper.Tweak(Target.Asp330Model);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SystemTestDate_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.SystemTestDate = UnitTestHelper.Tweak(Target.SystemTestDate);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PmDueDate_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.PmDueDate = UnitTestHelper.Tweak(Target.PmDueDate);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_RecordCreationStamp_NE()
        {
            // Arrange
            var entity = new Asp330CustomerCert(Target);
            var target = new Asp330CustomerCert(Target);
            entity.RecordCreationStamp = UnitTestHelper.Tweak(Target.RecordCreationStamp);

            // Act
            var actual = target.Equals(entity);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}