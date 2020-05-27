using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestLiIonBatteryCheckTests : DataUnitTestBase<Asp330TestLiIonBatteryCheck>
    {
        public Asp330TestLiIonBatteryCheckTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestLiIonBatteryCheckFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
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
            var target = new Asp330TestLiIonBatteryCheck(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
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
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            var target = new Asp330TestLiIonBatteryCheck(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
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
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ThresholdSecondsAboveCharge_NE()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            target.ThresholdSecondsAboveCharge = UnitTestHelper.Tweak(Target.ThresholdSecondsAboveCharge);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ThresholdSecondsAboveDischarge_NE()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            target.ThresholdSecondsAboveDischarge = UnitTestHelper.Tweak(Target.ThresholdSecondsAboveDischarge);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_BatteryDischargeTestPassed_NE()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            target.BatteryDischargeTestPassed = UnitTestHelper.Tweak(Target.BatteryDischargeTestPassed);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void BatteryChargeTestPassed_BatteryChargeTestPassed_NE()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            target.BatteryChargeTestPassed = UnitTestHelper.Tweak(Target.BatteryChargeTestPassed);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_BatteryAlarmsCheckPassed_NE()
        {
            // Arrange
            var target = new Asp330TestLiIonBatteryCheck(Target);
            var entity = new Asp330TestLiIonBatteryCheck(Target);
            target.BatteryAlarmsCheckPassed = UnitTestHelper.Tweak(Target.BatteryAlarmsCheckPassed);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}