using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_TEST_DATETIME_CHECK table
    /// This class may be accessed through its own Repository or as an element of the <see cref="Asp330Test"/> class
    /// </summary>
    public class Asp330TestDatetimeCheck : IEquatable<Asp330TestDatetimeCheck>
    {
        public Guid Asp330TestId { get; set; }
        public string DatetimeCheckSamDate { get; set; }
        public string DatetimeCheckSamTime { get; set; }
        public string DatetimeCheckPcDate { get; set; }
        public string DatetimeCheckPcTime { get; set; }
        public bool? ResultCheckBox { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestDatetimeCheck() { }

        public Asp330TestDatetimeCheck(Asp330TestDatetimeCheck that)
        {
            Asp330TestId = that.Asp330TestId;
            DatetimeCheckSamDate = that.DatetimeCheckSamDate;
            DatetimeCheckSamTime = that.DatetimeCheckSamTime;
            DatetimeCheckPcDate = that.DatetimeCheckPcDate;
            DatetimeCheckPcTime = that.DatetimeCheckPcTime;
            ResultCheckBox = that.ResultCheckBox;
        }

        public bool Equals(Asp330TestDatetimeCheck that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!DatetimeCheckSamDate.Equals(that.DatetimeCheckSamDate)) return false;
            if (!DatetimeCheckSamTime.Equals(that.DatetimeCheckSamTime)) return false;
            if (!DatetimeCheckPcDate.Equals(that.DatetimeCheckPcDate)) return false;
            if (!DatetimeCheckPcTime.Equals(that.DatetimeCheckPcTime)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestDatetimeCheck)that);
        }
    }
}
