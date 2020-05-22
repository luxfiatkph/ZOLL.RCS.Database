using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330TestTotalPowerFailureAlarm : IEquatable<Asp330TestTotalPowerFailureAlarm>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public bool? PowerSwitchOn { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestTotalPowerFailureAlarm() { }

        public Asp330TestTotalPowerFailureAlarm(Asp330TestTotalPowerFailureAlarm that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            PowerSwitchOn = that.PowerSwitchOn;
        }

        public bool Equals(Asp330TestTotalPowerFailureAlarm that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!PowerSwitchOn.Equals(that.PowerSwitchOn)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestTotalPowerFailureAlarm)that);
        }
    }
}