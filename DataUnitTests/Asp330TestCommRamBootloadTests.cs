using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330TestCommRamBootloadTests : DataUnitTestBase<Asp330TestCommRamBootload>
    {
        public Asp330TestCommRamBootloadTests()
        {
            var ids = new List<Guid> { Guid.NewGuid() };
            Target = FakerAsp330.Asp330TestCommRamBootloadFaker(ids)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
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
            var target = new Asp330TestCommRamBootload(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
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
            var entity = new Asp330TestCommRamBootload(Target);
            var target = new Asp330TestCommRamBootload(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_Asp330TestId_NE()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
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
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
            target.ResultCheckBox = UnitTestHelper.Tweak(Target.ResultCheckBox);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedAspRam_NE()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
            target.CheckPassedAspRam = UnitTestHelper.Tweak(Target.CheckPassedAspRam);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedSamComm_NE()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
            target.CheckPassedSamComm = UnitTestHelper.Tweak(Target.CheckPassedSamComm);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedAspComm_NE()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
            target.CheckPassedAspComm = UnitTestHelper.Tweak(Target.CheckPassedAspComm);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_CheckPassedAspWatchdog_NE()
        {
            // Arrange
            var target = new Asp330TestCommRamBootload(Target);
            var entity = new Asp330TestCommRamBootload(Target);
            target.CheckPassedAspWatchdog = UnitTestHelper.Tweak(Target.CheckPassedAspWatchdog);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}