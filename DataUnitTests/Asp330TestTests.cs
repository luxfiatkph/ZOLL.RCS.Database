using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestTests : DataUnitTestBase<Asp330Test>
    {
        public Asp330TestTests()
        {
            Target = FakerAsp330.Asp330TestFaker()[0];
            var ids = new List<Guid> { Target.Asp330TestId };

            Target.Asp330TestAspSelfCheck = FakerAsp330.Asp330TestAspSelfCheckFaker(ids)[0];
            Target.Asp330TestAspSelfCheck.Asp330Test = Target;
            Target.Asp330TestButtonCheck = FakerAsp330.Asp330TestButtonCheckFaker(ids)[0];
            Target.Asp330TestButtonCheck.Asp330Test = Target;
            Target.Asp330TestBuzzerCheck = FakerAsp330.Asp330TestBuzzerCheckFaker(ids)[0];
            Target.Asp330TestBuzzerCheck.Asp330Test = Target;

            Target.Asp330TestCommRamBootload = FakerAsp330.Asp330TestCommRamBootloadFaker(ids)[0];
            Target.Asp330TestCommRamBootload.Asp330Test = Target;
            Target.Asp330TestConditionalPmDueReset = FakerAsp330.Asp330TestConditionalPmDueResetFaker(ids)[0];
            Target.Asp330TestConditionalPmDueReset.Asp330Test = Target;
            Target.Asp330TestDatetimeCheck = FakerAsp330.Asp330TestDatetimeCheckFaker(ids)[0];
            Target.Asp330TestDatetimeCheck.Asp330Test = Target;

            Target.Asp330TestLcdContrastSet = FakerAsp330.Asp330TestLcdContrastSetFaker(ids)[0];
            Target.Asp330TestLcdContrastSet.Asp330Test = Target;
            Target.Asp330TestLcdVisualInspection = FakerAsp330.Asp330TestLcdVisualInspectionFaker(ids)[0];
            Target.Asp330TestLcdVisualInspection.Asp330Test = Target;
            Target.Asp330TestLedCheck = FakerAsp330.Asp330TestLedCheckFaker(ids)[0];
            Target.Asp330TestLedCheck.Asp330Test = Target;

            Target.Asp330TestLiIonBatteryCheck = FakerAsp330.Asp330TestLiIonBatteryCheckFaker(ids)[0];
            Target.Asp330TestLiIonBatteryCheck.Asp330Test = Target;
            Target.Asp330TestTotalPowerFailureAlarm = FakerAsp330.Asp330TestTotalPowerFailureAlarmFaker(ids)[0];
            Target.Asp330TestTotalPowerFailureAlarm.Asp330Test = Target;
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
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
            var target = new Asp330Test(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330Test(Target);
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
            var entity = new Asp330Test(Target);
            var target = new Asp330Test(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
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
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330Sn = UnitTestHelper.Tweak(Target.Asp330Sn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330Model_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330Model = UnitTestHelper.Tweak(Target.Asp330Model);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SamSn_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.SamSn = UnitTestHelper.Tweak(Target.SamSn);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_RcmId_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.RcmId = UnitTestHelper.Tweak(Target.RcmId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_UserGuid_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.UserGuid = UnitTestHelper.Tweak(Target.UserGuid);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_TestType_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.TestType = UnitTestHelper.Tweak(Target.TestType);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_TestSequenceName_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.TestSequenceName = UnitTestHelper.Tweak(Target.TestSequenceName);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_TestDate_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.TestDate = UnitTestHelper.Tweak(Target.TestDate);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Note_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Note = UnitTestHelper.Tweak(Target.Note);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestAspSelfCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestAspSelfCheck.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestAspSelfCheck.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestButtonCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestButtonCheck.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestButtonCheck.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestBuzzerCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestBuzzerCheck.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestBuzzerCheck.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestCommRamBootloadCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestCommRamBootload.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestCommRamBootload.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestConditionalPmDueReset_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestConditionalPmDueReset.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestConditionalPmDueReset.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestDatetimeCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestDatetimeCheck.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestDatetimeCheck.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestLcdContrastSet_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestLcdContrastSet.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestLcdContrastSet.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestLcdVisualInspection_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestLcdVisualInspection.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestLcdVisualInspection.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestLedCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestLedCheck.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestLedCheck.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestLiIonBatteryCheck_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestLiIonBatteryCheck.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestLiIonBatteryCheck.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestTotalPowerFailureAlarm_NE()
        {
            // Arrange
            var target = new Asp330Test(Target);
            var entity = new Asp330Test(Target);
            target.Asp330TestTotalPowerFailureAlarm.ResultCheckBox = UnitTestHelper.Tweak(target.Asp330TestTotalPowerFailureAlarm.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}