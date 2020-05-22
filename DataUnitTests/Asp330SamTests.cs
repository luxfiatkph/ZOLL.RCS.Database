using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330SamTests : DataUnitTestBase<Asp330Sam>
    {
        public Asp330SamTests()
        {
            Target = FakerAsp330.Asp330SamFaker(Faker.Random.Int())[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
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
            var target = new Asp330Sam(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330Sam(Target);
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
            var entity = new Asp330Sam(Target);
            var target = new Asp330Sam(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(entity.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SamSn_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.SamSn = UnitTestHelper.Tweak(entity.SamSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SamFirmware_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.SamFirmware = UnitTestHelper.Tweak(entity.SamFirmware);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_MinsOfOp_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.MinsOfOp = UnitTestHelper.Tweak(entity.MinsOfOp);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PumpSn_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.PumpSn = UnitTestHelper.Tweak(entity.PumpSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SamBoardSn_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.SamBoardSn = UnitTestHelper.Tweak(entity.SamBoardSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LastCalDate_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.LastCalDate = UnitTestHelper.Tweak(entity.LastCalDate);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Note_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.Note = UnitTestHelper.Tweak(entity.Note);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330Sam(Target);
            var entity = new Asp330Sam(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(entity.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}