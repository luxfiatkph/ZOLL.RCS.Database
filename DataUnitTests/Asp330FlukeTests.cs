using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330FlukeTests : DataUnitTestBase<Asp330Fluke>
    {
        public Asp330FlukeTests()
        {
            Target = FakerAsp330.Asp330FlukeFaker(Faker.Date.Future())[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
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
            var target = new Asp330Fluke(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
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
            var entity = new Asp330Fluke(Target);
            var target = new Asp330Fluke(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(Target.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_FlukeSn_NE()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
            target.FlukeSn = UnitTestHelper.Tweak(entity.FlukeSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_FlukeModel_NE()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
            target.FlukeModel = UnitTestHelper.Tweak(entity.FlukeModel);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_DeviceVersion_NE()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
            target.DeviceVersion = UnitTestHelper.Tweak(entity.DeviceVersion);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CalDueDate_NE()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
            target.CalDueDate = UnitTestHelper.Tweak(entity.CalDueDate);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330Fluke(Target);
            var entity = new Asp330Fluke(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(entity.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }

}