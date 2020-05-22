using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestTotalPowerFailureAlarmTests : DataUnitTestBase<Asp330TestTotalPowerFailureAlarm>
    {
        public Asp330TestTotalPowerFailureAlarmTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestTotalPowerFailureAlarmFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestTotalPowerFailureAlarm(Target);
            var entity = new Asp330TestTotalPowerFailureAlarm(Target);
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
            var target = new Asp330TestTotalPowerFailureAlarm(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestTotalPowerFailureAlarm(Target);
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
            var entity = new Asp330TestTotalPowerFailureAlarm(Target);
            var target = new Asp330TestTotalPowerFailureAlarm(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestTotalPowerFailureAlarm(Target);
            var entity = new Asp330TestTotalPowerFailureAlarm(Target);
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
            var target = new Asp330TestTotalPowerFailureAlarm(Target);
            var entity = new Asp330TestTotalPowerFailureAlarm(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PowerSwitchOn_NE()
        {
            // Arrange
            var target = new Asp330TestTotalPowerFailureAlarm(Target);
            var entity = new Asp330TestTotalPowerFailureAlarm(Target);
            target.PowerSwitchOn = UnitTestHelper.Tweak(Target.PowerSwitchOn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

    }
}