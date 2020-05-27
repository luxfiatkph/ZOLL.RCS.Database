using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestLcdVisualInspectionTests : DataUnitTestBase<Asp330TestLcdVisualInspection>
    {
        public Asp330TestLcdVisualInspectionTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestLcdVisualInspectionFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
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
            var target = new Asp330TestLcdVisualInspection(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
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
            var entity = new Asp330TestLcdVisualInspection(Target);
            var target = new Asp330TestLcdVisualInspection(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(Target.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LcdArtifactFree_NE()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
            target.LcdArtifactFree = UnitTestHelper.Tweak(Target.LcdArtifactFree);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LcdBacklightEven_NE()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
            target.LcdBacklightEven = UnitTestHelper.Tweak(Target.LcdBacklightEven);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LcdBlemishFree_NE()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
            target.LcdBlemishFree = UnitTestHelper.Tweak(Target.LcdBlemishFree);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LcdContrastGood_NE()
        {
            // Arrange
            var target = new Asp330TestLcdVisualInspection(Target);
            var entity = new Asp330TestLcdVisualInspection(Target);
            target.LcdContrastGood = UnitTestHelper.Tweak(Target.LcdContrastGood);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}