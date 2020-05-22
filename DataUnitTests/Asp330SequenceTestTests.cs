using Microsoft.VisualStudio.TestTools.UnitTesting;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public class Asp330SequenceTestTests : DataUnitTestBase<Asp330SequenceTest>
    {
        public Asp330SequenceTestTests()
        {
            var sequenceId = Faker.Random.Short(0, 500);
            var testId = Faker.Random.Short(0, 500);
            Target = FakerAsp330.Asp330SequenceTestFaker(sequenceId, testId)[0];
        }

        [TestMethod]
        public override void EqualsObject_CorrectType()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
            var entity = new Asp330SequenceTest(Target);
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
            var target = new Asp330SequenceTest(Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public override void EqualsEntity_Reference()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
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
            var entity = new Asp330SequenceTest(Target);
            var target = new Asp330SequenceTest(Target);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsEntity_TestId_NE()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
            var entity = new Asp330SequenceTest(Target);
            target.TestId = UnitTestHelper.Tweak(Target.TestId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SequenceId_NE()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
            var entity = new Asp330SequenceTest(Target);
            target.SequenceId = UnitTestHelper.Tweak(Target.SequenceId);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_SequenceName_NE()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
            var entity = new Asp330SequenceTest(Target);
            target.SequenceName = UnitTestHelper.Tweak(Target.SequenceName);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsEntity_TestName_NE()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
            var entity = new Asp330SequenceTest(Target);
            target.TestName = UnitTestHelper.Tweak(Target.TestName);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
        [TestMethod]
        public void EqualsEntity_TestTableName_NE()
        {
            // Arrange
            var target = new Asp330SequenceTest(Target);
            var entity = new Asp330SequenceTest(Target);
            target.TestTableName = UnitTestHelper.Tweak(Target.TestTableName);

            // Act
            var actual = entity.Equals(target);

            // Assert
            Assert.IsFalse(actual);
        }
    }
}