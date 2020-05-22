using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330Device : IEquatable<Asp330Device>
    {
        public Guid Asp330TestId { get; set; }
        public string Asp330Sn { get; set; }
        public string Asp330Model { get; set; }
        public string SamSn { get; set; }
        public int? LcdContrast { get; set; }
        public string CpuSn { get; set; }
        public string UimSn { get; set; }
        public string PimSn { get; set; }
        public string Asp330Firmware { get; set; }
        public string BootVersion { get; set; }
        public string LangVersion { get; set; }
        public string ConfigVersion { get; set; }
        public string ConfigFileNumber { get; set; }
        public string Note { get; set; }
        public bool? ResultCheckBox { get; set; }

        public Asp330Device() { }

        public Asp330Device(Asp330Device that)
        {
            Asp330TestId = that.Asp330TestId;
            Asp330Sn = that.Asp330Sn;
            Asp330Model = that.Asp330Model;
            SamSn = that.SamSn;
            LcdContrast = that.LcdContrast;
            CpuSn = that.CpuSn;
            UimSn = that.UimSn;
            PimSn = that.PimSn;
            Asp330Firmware = that.Asp330Firmware;
            BootVersion = that.BootVersion;
            LangVersion = that.LangVersion;
            ConfigVersion = that.ConfigVersion;
            ConfigFileNumber = that.ConfigFileNumber;
            Note = that.Note;
            ResultCheckBox = that.ResultCheckBox;
        }

        public bool Equals(Asp330Device that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (!Asp330Sn.Equals(that.Asp330Sn)) return false;
            if (!Asp330Model.Equals(that.Asp330Model)) return false;
            if (!SamSn.Equals(that.SamSn)) return false;
            if (!LcdContrast.Equals(that.LcdContrast)) return false;
            if (!CpuSn.Equals(that.CpuSn)) return false;
            if (!UimSn.Equals(that.UimSn)) return false;
            if (!PimSn.Equals(that.PimSn)) return false;
            if (!Asp330Firmware.Equals(that.Asp330Firmware)) return false;
            if (!BootVersion.Equals(that.BootVersion)) return false;
            if (!LangVersion.Equals(that.LangVersion)) return false;
            if (!ConfigVersion.Equals(that.ConfigVersion)) return false;
            if (!ConfigFileNumber.Equals(that.ConfigFileNumber)) return false;
            if (!Note.Equals(that.Note)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330Device)that);
        }
    }
}