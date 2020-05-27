using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestLcdContrastSetTests : DataUnitTestBase<Asp330TestLcdContrastSet>
    {
        public Asp330TestLcdContrastSetTests()
        {
            var ids = new List<Guid> {Guid.NewGuid()};
            Target = FakerAsp330.Asp330TestLcdContrastSetFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);
            var entity = new Asp330TestLcdContrastSet(Target);
            var targetObject = (object) target;

            // Act
            var actual = entity.Equals(targetObject);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Null()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);
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
            var entity = new Asp330TestLcdContrastSet(Target);
            var target = new Asp330TestLcdContrastSet(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);
            var entity = new Asp330TestLcdContrastSet(Target);
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
            var target = new Asp330TestLcdContrastSet(Target);
            var entity = new Asp330TestLcdContrastSet(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SettingContrast_NE()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);
            var entity = new Asp330TestLcdContrastSet(Target);
            target.SettingContrast = UnitTestHelper.Tweak(Target.SettingContrast);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SettingLowLimit_NE()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);
            var entity = new Asp330TestLcdContrastSet(Target);
            target.SettingLowLimit = UnitTestHelper.Tweak(Target.SettingLowLimit);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SettingHighLimit_NE()
        {
            // Arrange
            var target = new Asp330TestLcdContrastSet(Target);
            var entity = new Asp330TestLcdContrastSet(Target);
            target.SettingHighLimit = UnitTestHelper.Tweak(Target.SettingHighLimit);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}