using System;
using Bogus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ZOLL.RCS.Database.DataUnitTests
{
    [TestClass]
    public abstract class DataUnitTestBase<TEntity> where TEntity : class
    {
        protected Faker Faker { get; } = new Faker();
        protected TEntity Target { get; set; }

        [TestMethod]
        public void EqualsObject_Null()
        {
            // Arrange
            var target = (TEntity)Activator.CreateInstance(typeof(TEntity), Target);

            // Act
            var actual = target.Equals(null);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void EqualsObject_Reference()
        {
            // Arrange
            var target = (TEntity)Activator.CreateInstance(typeof(TEntity), Target);
            var targetRef = target;
            var targetRefObj = (object)targetRef;

            // Act
            var actual = target.Equals(targetRefObj);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void EqualsObject_WrongType()
        {
            // Arrange
            var target = (TEntity)Activator.CreateInstance(typeof(TEntity), Target);

            // Act
            var actual = target.Equals(new object());

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public abstract void EqualsObject_CorrectType();

        [TestMethod]
        public abstract void EqualsEntity_Null();

        [TestMethod]
        public abstract void EqualsEntity_Reference();

        [TestMethod]
        public abstract void EqualsEntity_Equal();
    }
}