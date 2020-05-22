using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public sealed class Asp330TestAspSelfCheck : IEquatable<Asp330TestAspSelfCheck>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public bool? PassedPowerSelfCheck { get; set; }
        public bool? PassedCommSelfCheck { get; set; }
        public bool? PassedSamSelfCheck { get; set; }
        public bool? PassedTemperatureSelfCheck { get; set; }
        public Asp330Test Asp330Test { get; set; }

        public Asp330TestAspSelfCheck() { }

        public Asp330TestAspSelfCheck(Asp330TestAspSelfCheck that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            PassedPowerSelfCheck = that.PassedPowerSelfCheck;
            PassedCommSelfCheck = that.PassedCommSelfCheck;
            PassedSamSelfCheck = that.PassedSamSelfCheck;
            PassedTemperatureSelfCheck = that.PassedTemperatureSelfCheck;
        }

        public bool Equals(Asp330TestAspSelfCheck that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!PassedPowerSelfCheck.Equals(that.PassedPowerSelfCheck)) return false;
            if (!PassedCommSelfCheck.Equals(that.PassedCommSelfCheck)) return false;
            if (!PassedSamSelfCheck.Equals(that.PassedSamSelfCheck)) return false;
            if (!PassedTemperatureSelfCheck.Equals(that.PassedTemperatureSelfCheck)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestAspSelfCheck)that);
        }
    }
}