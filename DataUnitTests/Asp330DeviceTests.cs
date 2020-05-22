using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330DeviceTests : DataUnitTestBase<Asp330Device>
    {
        public Asp330DeviceTests()
        {
            Target = FakerAsp330.Asp330DeviceFaker(Faker.Random.Int(0, 500))[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330Device(Target);
            var entity = new Asp330Device(Target);
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
            var target = new Asp330Device(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330Device(Target);
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
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330Device(Target);
            var entity = new Asp330Device(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(Target.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330Sn_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.Asp330Sn = UnitTestHelper.Tweak(target.Asp330Sn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330Model_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.Asp330Model = UnitTestHelper.Tweak(target.Asp330Model);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SamSn_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.SamSn = UnitTestHelper.Tweak(target.SamSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LcdContrast_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.LcdContrast = UnitTestHelper.Tweak(target.LcdContrast);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CpuSn_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.CpuSn = UnitTestHelper.Tweak(target.CpuSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_UimSn_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.UimSn = UnitTestHelper.Tweak(target.UimSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PimSn_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.PimSn = UnitTestHelper.Tweak(target.PimSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330Firmware_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.Asp330Firmware = UnitTestHelper.Tweak(target.Asp330Firmware);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_BootVersion_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.BootVersion = UnitTestHelper.Tweak(target.BootVersion);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LangVersion_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.LangVersion = UnitTestHelper.Tweak(target.LangVersion);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ConfigVersion_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.ConfigVersion = UnitTestHelper.Tweak(target.ConfigVersion);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ConfigFileNumber_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.ConfigFileNumber = UnitTestHelper.Tweak(target.ConfigFileNumber);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Note_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.Note = UnitTestHelper.Tweak(target.Note);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var entity = new Asp330Device(Target);
            var target = new Asp330Device(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}