using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330TestLcdContrastSet : IEquatable<Asp330TestLcdContrastSet>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public int? SettingContrast { get; set; }
        public int? SettingLowLimit { get; set; }
        public int? SettingHighLimit { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestLcdContrastSet() { }

        public Asp330TestLcdContrastSet(Asp330TestLcdContrastSet that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            SettingContrast = that.SettingContrast;
            SettingLowLimit = that.SettingLowLimit;
            SettingHighLimit = that.SettingHighLimit;
        }

        public bool Equals(Asp330TestLcdContrastSet that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!SettingContrast.Equals(that.SettingContrast)) return false;
            if (!SettingLowLimit.Equals(that.SettingLowLimit)) return false;
            if (!SettingHighLimit.Equals(that.SettingHighLimit)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestLcdContrastSet)that);
        }
    }
}