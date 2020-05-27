using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_SAM table
    /// </summary>
    public class Asp330Sam : IEquatable<Asp330Sam>
    {
        public Guid Asp330TestId { get; set; }
        public string SamSn { get; set; }
        public string SamFirmware { get; set; }
        public int? MinsOfOp { get; set; }
        public string PumpSn { get; set; }
        public string SamBoardSn { get; set; }
        public DateTime? LastCalDate { get; set; }
        public string Note { get; set; }
        public bool? ResultCheckBox { get; set; }

        public Asp330Sam() { }

        public Asp330Sam(Asp330Sam that)
        {
            Asp330TestId = that.Asp330TestId;
            SamSn = that.SamSn;
            SamFirmware = that.SamFirmware;
            MinsOfOp = that.MinsOfOp;
            PumpSn = that.PumpSn;
            SamBoardSn = that.SamBoardSn;
            LastCalDate = that.LastCalDate;
            Note = that.Note;
            ResultCheckBox = that.ResultCheckBox;
        }

        public bool Equals(Asp330Sam that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!SamSn.Equals(that.SamSn)) return false;
            if (!SamFirmware.Equals(that.SamFirmware)) return false;
            if (!MinsOfOp.Equals(that.MinsOfOp)) return false;
            if (!PumpSn.Equals(that.PumpSn)) return false;
            if (!SamBoardSn.Equals(that.SamBoardSn)) return false;
            if (!LastCalDate.Equals(that.LastCalDate)) return false;
            if (!Note.Equals(that.Note)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330Sam)that);
        }
    }
}