using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestButtonCheckTests : DataUnitTestBase<Asp330TestButtonCheck>
    {
        public Asp330TestButtonCheckTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestButtonCheckFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
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
            var target = new Asp330TestButtonCheck(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
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
            var entity = new Asp330TestButtonCheck(Target);
            var target = new Asp330TestButtonCheck(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(Target.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedSmartFlowOnButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedSmartFlowOnButton = UnitTestHelper.Tweak(Target.CheckPassedSmartFlowOnButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedSmartFlowCalButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedSmartFlowCalButton = UnitTestHelper.Tweak(Target.CheckPassedSmartFlowCalButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedModeButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedModeButton = UnitTestHelper.Tweak(Target.CheckPassedModeButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedSelectConfirmButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedSelectConfirmButton = UnitTestHelper.Tweak(Target.CheckPassedSelectConfirmButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedSurgicalButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedSurgicalButton = UnitTestHelper.Tweak(Target.CheckPassedSurgicalButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedPharyngealButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedPharyngealButton = UnitTestHelper.Tweak(Target.CheckPassedPharyngealButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedTrachealButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedTrachealButton = UnitTestHelper.Tweak(Target.CheckPassedTrachealButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedCassButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedCassButton = UnitTestHelper.Tweak(Target.CheckPassedCassButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedMenuButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedMenuButton = UnitTestHelper.Tweak(Target.CheckPassedMenuButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedMuteCancelButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedMuteCancelButton = UnitTestHelper.Tweak(Target.CheckPassedMuteCancelButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedStandbyButton_NE()
        {
            // Arrange
            var target = new Asp330TestButtonCheck(Target);
            var entity = new Asp330TestButtonCheck(Target);
            target.CheckPassedStandbyButton = UnitTestHelper.Tweak(Target.CheckPassedStandbyButton);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}