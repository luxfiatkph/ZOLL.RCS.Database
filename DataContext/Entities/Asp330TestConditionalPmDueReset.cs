using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330TestConditionalPmDueReset : IEquatable<Asp330TestConditionalPmDueReset>
    {
        public Guid Asp330TestId { get; set; }
        public int? PmDueResetRuntimeMinutes { get; set; }
        public int? PmDueResetTotalMinute { get; set; }
        public DateTime? PmDueResetCalDate { get; set; }
        public bool? ResultCheckBox { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestConditionalPmDueReset() { }

        public Asp330TestConditionalPmDueReset(Asp330TestConditionalPmDueReset that)
        {
            Asp330TestId = that.Asp330TestId;
            PmDueResetRuntimeMinutes = that.PmDueResetRuntimeMinutes;
            PmDueResetTotalMinute = that.PmDueResetTotalMinute;
            PmDueResetCalDate = that.PmDueResetCalDate;
            ResultCheckBox = that.ResultCheckBox;
        }

        public bool Equals(Asp330TestConditionalPmDueReset that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!PmDueResetRuntimeMinutes.Equals(that.PmDueResetRuntimeMinutes)) return false;
            if (!PmDueResetTotalMinute.Equals(that.PmDueResetTotalMinute)) return false;
            if (!PmDueResetCalDate.Equals(that.PmDueResetCalDate)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestConditionalPmDueReset)that);
        }
    }
}