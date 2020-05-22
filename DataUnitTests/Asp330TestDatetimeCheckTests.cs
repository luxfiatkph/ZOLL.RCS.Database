using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestDatetimeCheckTests : DataUnitTestBase<Asp330TestDatetimeCheck>
    {
        public Asp330TestDatetimeCheckTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestDatetimeCheckFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
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
            var target = new Asp330TestDatetimeCheck(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
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
            var entity = new Asp330TestDatetimeCheck(Target);
            var target = new Asp330TestDatetimeCheck(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(Target.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_DatetimeCheckSamDate_NE()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
            target.DatetimeCheckSamDate = UnitTestHelper.Tweak(Target.DatetimeCheckSamDate);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_DatetimeCheckSamTime_NE()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
            target.DatetimeCheckSamTime = UnitTestHelper.Tweak(Target.DatetimeCheckSamTime);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_DatetimeCheckPcDate_NE()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
            target.DatetimeCheckPcDate = UnitTestHelper.Tweak(Target.DatetimeCheckPcDate);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_DatetimeCheckPcTime_NE()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
            target.DatetimeCheckPcTime = UnitTestHelper.Tweak(Target.DatetimeCheckPcTime);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330TestDatetimeCheck(Target);
            var entity = new Asp330TestDatetimeCheck(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}