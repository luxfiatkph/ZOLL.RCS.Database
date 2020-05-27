using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_TEST_BUZZER_CHECK table
    /// This class may be accessed through its own Repository or as an element of the <see cref="Asp330Test"/> class
    /// </summary>
    public class Asp330TestBuzzerCheck : IEquatable<Asp330TestBuzzerCheck>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public Asp330Test Asp330Test { get; set; }

        public Asp330TestBuzzerCheck() { }

        public Asp330TestBuzzerCheck(Asp330TestBuzzerCheck that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
        }

        public bool Equals(Asp330TestBuzzerCheck that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestBuzzerCheck)that);
        }
    }
}