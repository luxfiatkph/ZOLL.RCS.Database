using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public sealed class Asp330Test : IEquatable<Asp330Test>
    {
        public Guid Asp330TestId { get; set; }
        public string Asp330Sn { get; set; }
        public string Asp330Model { get; set; }
        public string SamSn { get; set; }
        public Guid? RcmId { get; set; }
        public Guid? UserGuid { get; set; }
        public int? TestType { get; set; }
        public string TestSequenceName { get; set; }
        public DateTime? TestDate { get; set; }
        public string Note { get; set; }
        public bool? ResultCheckBox { get; set; }

        private Asp330TestAspSelfCheck _asp330TestAspSelfCheck;
        public Asp330TestAspSelfCheck Asp330TestAspSelfCheck
        {
            get => _asp330TestAspSelfCheck;
            set
            {
                _asp330TestAspSelfCheck = value;
                if (value == null) return;
                _asp330TestAspSelfCheck.Asp330Test = this;
            }
        }

        private Asp330TestButtonCheck _asp330TestButtonCheck;
        public Asp330TestButtonCheck Asp330TestButtonCheck
        {
            get => _asp330TestButtonCheck;
            set
            {
                _asp330TestButtonCheck = value;
                if (value == null) return;
                _asp330TestButtonCheck.Asp330Test = this;
            }
        }

        private Asp330TestBuzzerCheck _asp330TestBuzzerCheck;
        public Asp330TestBuzzerCheck Asp330TestBuzzerCheck
        {
            get => _asp330TestBuzzerCheck;
            set
            {
                _asp330TestBuzzerCheck = value;
                if (value == null) return;
                _asp330TestBuzzerCheck.Asp330Test = this;
            }
        }

        private Asp330TestCommRamBootload _asp330TestCommRamBootload;
        public Asp330TestCommRamBootload Asp330TestCommRamBootload
        {
            get => _asp330TestCommRamBootload;
            set
            {
                _asp330TestCommRamBootload = value;
                if (value == null) return;
                _asp330TestCommRamBootload.Asp330Test = this;
            }
        }

        private Asp330TestConditionalPmDueReset _asp330TestConditionalPmDueReset;
        public Asp330TestConditionalPmDueReset Asp330TestConditionalPmDueReset
        {
            get => _asp330TestConditionalPmDueReset;
            set
            {
                _asp330TestConditionalPmDueReset = value;
                if (value == null) return;
                _asp330TestConditionalPmDueReset.Asp330Test = this;
            }
        }

        private Asp330TestDatetimeCheck _asp330TestDatetimeCheck;
        public Asp330TestDatetimeCheck Asp330TestDatetimeCheck
        {
            get => _asp330TestDatetimeCheck;
            set
            {
                _asp330TestDatetimeCheck = value;
                if (value == null) return;
                _asp330TestDatetimeCheck.Asp330Test = this;
            }
        }

        private Asp330TestLcdContrastSet _asp330TestLcdContrastSet;
        public Asp330TestLcdContrastSet Asp330TestLcdContrastSet
        {
            get => _asp330TestLcdContrastSet;
            set
            {
                _asp330TestLcdContrastSet = value;
                if (value == null) return;
                _asp330TestLcdContrastSet.Asp330Test = this;
            }
        }

        private Asp330TestTotalPowerFailureAlarm _asp330TestTotalPowerFailureAlarm;
        public Asp330TestTotalPowerFailureAlarm Asp330TestTotalPowerFailureAlarm
        {
            get => _asp330TestTotalPowerFailureAlarm;
            set
            {
                _asp330TestTotalPowerFailureAlarm = value;
                if (value == null) return;
                _asp330TestTotalPowerFailureAlarm.Asp330Test = this;
            }
        }

        public Asp330Test() { }

        public Asp330Test(Asp330Test that)
        {
            Asp330TestId = that.Asp330TestId;
            Asp330Sn = that.Asp330Sn;
            Asp330Model = that.Asp330Model;
            SamSn = that.SamSn;
            RcmId = that.RcmId;
            UserGuid = that.UserGuid;
            TestType = that.TestType;
            TestSequenceName = that.TestSequenceName;
            TestDate = that.TestDate;
            Note = that.Note;
            ResultCheckBox = that.ResultCheckBox;
            Asp330TestAspSelfCheck = new Asp330TestAspSelfCheck(that.Asp330TestAspSelfCheck) { Asp330Test = this };
            Asp330TestButtonCheck = new Asp330TestButtonCheck(that.Asp330TestButtonCheck) { Asp330Test = this };
            Asp330TestBuzzerCheck = new Asp330TestBuzzerCheck(that.Asp330TestBuzzerCheck) { Asp330Test = this };
            Asp330TestCommRamBootload = new Asp330TestCommRamBootload(that.Asp330TestCommRamBootload) { Asp330Test = this };
            Asp330TestConditionalPmDueReset = new Asp330TestConditionalPmDueReset(that.Asp330TestConditionalPmDueReset) { Asp330Test = this };
            Asp330TestDatetimeCheck = new Asp330TestDatetimeCheck(that.Asp330TestDatetimeCheck) { Asp330Test = this };
            Asp330TestLcdContrastSet = new Asp330TestLcdContrastSet(that.Asp330TestLcdContrastSet) { Asp330Test = this };
            Asp330TestTotalPowerFailureAlarm = new Asp330TestTotalPowerFailureAlarm(that.Asp330TestTotalPowerFailureAlarm) { Asp330Test = this };
        }

        public bool Equals(Asp330Test that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!Asp330Sn.Equals(that.Asp330Sn)) return false;
            if (!Asp330Model.Equals(that.Asp330Model)) return false;
            if (!SamSn.Equals(that.SamSn)) return false;
            if (!RcmId.Equals(that.RcmId)) return false;
            if (!UserGuid.Equals(that.UserGuid)) return false;
            if (!TestType.Equals(that.TestType)) return false;
            if (!TestSequenceName.Equals(that.TestSequenceName)) return false;
            if (!TestDate.Equals(that.TestDate)) return false;
            if (!Note.Equals(that.Note)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!Asp330TestAspSelfCheck.Equals(that.Asp330TestAspSelfCheck)) return false;
            if (!Asp330TestButtonCheck.Equals(that.Asp330TestButtonCheck)) return false;
            if (!Asp330TestBuzzerCheck.Equals(that.Asp330TestBuzzerCheck)) return false;
            if (!Asp330TestCommRamBootload.Equals(that.Asp330TestCommRamBootload)) return false;
            if (!Asp330TestConditionalPmDueReset.Equals(that.Asp330TestConditionalPmDueReset)) return false;
            if (!Asp330TestDatetimeCheck.Equals(that.Asp330TestDatetimeCheck)) return false;
            if (!Asp330TestLcdContrastSet.Equals(that.Asp330TestLcdContrastSet)) return false;
            if (!Asp330TestTotalPowerFailureAlarm.Equals(that.Asp330TestTotalPowerFailureAlarm)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330Test)that);
        }
    }
}