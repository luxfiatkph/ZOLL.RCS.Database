using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestConditionalPmDueResetTests : DataUnitTestBase<Asp330TestConditionalPmDueReset>
    {
        public Asp330TestConditionalPmDueResetTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestConditionalPmDueResetFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
            var entity = new Asp330TestConditionalPmDueReset(Target);
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
            var target = new Asp330TestConditionalPmDueReset(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
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
            var entity = new Asp330TestConditionalPmDueReset(Target);
            var target = new Asp330TestConditionalPmDueReset(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
            var entity = new Asp330TestConditionalPmDueReset(Target);
            target.Asp330TestId = UnitTestHelper.Tweak(Target.Asp330TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PmDueResetRuntimeMinutes_NE()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
            var entity = new Asp330TestConditionalPmDueReset(Target);
            target.PmDueResetRuntimeMinutes = UnitTestHelper.Tweak(Target.PmDueResetRuntimeMinutes);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PmDueResetTotalMinute_NE()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
            var entity = new Asp330TestConditionalPmDueReset(Target);
            target.PmDueResetTotalMinute = UnitTestHelper.Tweak(Target.PmDueResetTotalMinute);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PmDueResetCalDate_NE()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
            var entity = new Asp330TestConditionalPmDueReset(Target);
            target.PmDueResetCalDate = UnitTestHelper.Tweak(Target.PmDueResetCalDate);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_ResultCheckBox_NE()
        {
            // Arrange
            var target = new Asp330TestConditionalPmDueReset(Target);
            var entity = new Asp330TestConditionalPmDueReset(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

    }
}