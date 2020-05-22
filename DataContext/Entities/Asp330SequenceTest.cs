using System;
// ReSharper disable ConvertIfStatementToReturnStatement
// ReSharper disable UnusedMember.Global
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330SequenceTest : IEquatable<Asp330SequenceTest>
    {
        public short SequenceId { get; set; }
        public short TestId { get; set; }
        public string SequenceName { get; set; }
        public string TestName { get; set; }
        public string TestTableName { get; set; }

        public Asp330SequenceTest() { }

        public Asp330SequenceTest(Asp330SequenceTest that)
        {
            SequenceId = that.SequenceId;
            TestId = that.TestId;
            SequenceName = that.SequenceName;
            TestName = that.TestName;
            TestTableName = that.TestTableName;
        }

        public bool Equals(Asp330SequenceTest that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!SequenceId.Equals(that.SequenceId)) return false;
            if (!TestId.Equals(that.TestId)) return false;
            if (!SequenceName.Equals(that.SequenceName)) return false;
            if (!TestName.Equals(that.TestName)) return false;
            if (!TestTableName.Equals(that.TestTableName)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330SequenceTest)that);
        }
    }
}