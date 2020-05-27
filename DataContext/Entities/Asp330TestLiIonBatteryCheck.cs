using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_TEST_LI_ION_BATTERY_CHECK table
    /// This class may be accessed through its own Repository or as an element of the <see cref="Asp330Test"/> class
    /// </summary>
    public class Asp330TestLiIonBatteryCheck
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public int? ThresholdSecondsAboveCharge { get; set; }
        public int? ThresholdSecondsAboveDischarge { get; set; }
        public bool? BatteryDischargeTestPassed { get; set; }
        public bool? BatteryChargeTestPassed { get; set; }
        public bool? BatteryAlarmsCheckPassed { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestLiIonBatteryCheck() { }

        public Asp330TestLiIonBatteryCheck(Asp330TestLiIonBatteryCheck that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            ThresholdSecondsAboveCharge = that.ThresholdSecondsAboveCharge;
            ThresholdSecondsAboveDischarge = that.ThresholdSecondsAboveDischarge;
            BatteryDischargeTestPassed = that.BatteryDischargeTestPassed;
            BatteryChargeTestPassed = that.BatteryChargeTestPassed;
            BatteryAlarmsCheckPassed = that.BatteryAlarmsCheckPassed;
        }

        public bool Equals(Asp330TestLiIonBatteryCheck that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!ThresholdSecondsAboveCharge.Equals(that.ThresholdSecondsAboveCharge)) return false;
            if (!ThresholdSecondsAboveDischarge.Equals(that.ThresholdSecondsAboveDischarge)) return false;
            if (!BatteryDischargeTestPassed.Equals(that.BatteryDischargeTestPassed)) return false;
            if (!BatteryChargeTestPassed.Equals(that.BatteryChargeTestPassed)) return false;
            if (!BatteryAlarmsCheckPassed.Equals(that.BatteryAlarmsCheckPassed)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestLiIonBatteryCheck)that);
        }
    }
}