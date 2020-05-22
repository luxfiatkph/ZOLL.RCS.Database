using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330TestCommRamBootload : IEquatable<Asp330TestCommRamBootload>
    {
        public Guid Asp330TestId { get; set; }
        public bool? ResultCheckBox { get; set; }
        public bool? CheckPassedAspRam { get; set; }
        public bool? CheckPassedSamComm { get; set; }
        public bool? CheckPassedAspComm { get; set; }
        public bool? CheckPassedAspWatchdog { get; set; }
        public virtual Asp330Test Asp330Test { get; set; }

        public Asp330TestCommRamBootload() { }

        public Asp330TestCommRamBootload(Asp330TestCommRamBootload that)
        {
            Asp330TestId = that.Asp330TestId;
            ResultCheckBox = that.ResultCheckBox;
            CheckPassedAspRam = that.CheckPassedAspRam;
            CheckPassedSamComm = that.CheckPassedSamComm;
            CheckPassedAspComm = that.CheckPassedAspComm;
            CheckPassedAspWatchdog = that.CheckPassedAspWatchdog;
        }

        public bool Equals(Asp330TestCommRamBootload that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            if (!CheckPassedAspRam.Equals(that.CheckPassedAspRam)) return false;
            if (!CheckPassedSamComm.Equals(that.CheckPassedSamComm)) return false;
            if (!CheckPassedAspComm.Equals(that.CheckPassedAspComm)) return false;
            if (!CheckPassedAspWatchdog.Equals(that.CheckPassedAspWatchdog)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330TestCommRamBootload)that);
        }
    }
}