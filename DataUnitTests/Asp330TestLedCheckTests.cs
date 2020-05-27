using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestLedCheckTests : DataUnitTestBase<Asp330TestLedCheck>
    {
        public Asp330TestLedCheckTests()
        {
            var ids = new List<Guid> {Guid.NewGuid()};
            Target = FakerAsp330.Asp330TestLedCheckFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
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
            var target = new Asp330TestLedCheck(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
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
            var entity = new Asp330TestLedCheck(Target);
            var target = new Asp330TestLedCheck(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
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
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LedCheckPassedYellow_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.LedCheckPassedYellow = UnitTestHelper.Tweak(Target.LedCheckPassedYellow);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LedCheckPassedRed_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.LedCheckPassedRed = UnitTestHelper.Tweak(Target.LedCheckPassedRed);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LedCheckPassedMuteButton_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.LedCheckPassedMuteButton = UnitTestHelper.Tweak(Target.LedCheckPassedMuteButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LedCheckPassedIr_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.LedCheckPassedIr = UnitTestHelper.Tweak(Target.LedCheckPassedIr);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LedCheckPassedGreen_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.LedCheckPassedGreen = UnitTestHelper.Tweak(Target.LedCheckPassedGreen);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_LedCheckPassedSelectButton_NE()
        {
            // Arrange
            var target = new Asp330TestLedCheck(Target);
            var entity = new Asp330TestLedCheck(Target);
            target.LedCheckPassedSelectButton = UnitTestHelper.Tweak(Target.LedCheckPassedSelectButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}