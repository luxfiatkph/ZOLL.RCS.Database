using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestAspSelfCheckTests : DataUnitTestBase<Asp330TestAspSelfCheck>
    {
        public Asp330TestAspSelfCheckTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestAspSelfCheckFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
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
            var target = new Asp330TestAspSelfCheck(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
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
            var entity = new Asp330TestAspSelfCheck(Target);
            var target = new Asp330TestAspSelfCheck(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
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
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PassedCommSelfCheck_NE()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
            target.PassedCommSelfCheck = UnitTestHelper.Tweak(Target.PassedCommSelfCheck);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PassedPowerSelfCheck_NE()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
            target.PassedPowerSelfCheck = UnitTestHelper.Tweak(Target.PassedPowerSelfCheck);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PassedSamSelfCheck_NE()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
            target.PassedSamSelfCheck = UnitTestHelper.Tweak(Target.PassedSamSelfCheck);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_PassedTemperatureSelfCheck_NE()
        {
            // Arrange
            var target = new Asp330TestAspSelfCheck(Target);
            var entity = new Asp330TestAspSelfCheck(Target);
            target.PassedTemperatureSelfCheck = UnitTestHelper.Tweak(Target.PassedTemperatureSelfCheck);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}