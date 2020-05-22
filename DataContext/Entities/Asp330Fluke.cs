using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    public class Asp330Fluke : IEquatable<Asp330Fluke>
    {
        public Guid Asp330TestId { get; set; }
        public string FlukeSn { get; set; }
        public string FlukeModel { get; set; }
        public string DeviceVersion { get; set; }
        public DateTime? CalDueDate { get; set; }
        public bool? ResultCheckBox { get; set; }

        public Asp330Fluke() { }

        public Asp330Fluke(Asp330Fluke that)
        {
            Asp330TestId = that.Asp330TestId;
            FlukeSn = that.FlukeSn;
            FlukeModel = that.FlukeModel;
            DeviceVersion = that.DeviceVersion;
            CalDueDate = that.CalDueDate;
            ResultCheckBox = that.ResultCheckBox;
        }

        public bool Equals(Asp330Fluke that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330TestId.Equals(that.Asp330TestId)) return false;
            if (FlukeSn != that.FlukeSn) return false;
            if (FlukeModel != that.FlukeModel) return false;
            if (DeviceVersion != that.DeviceVersion) return false;
            if (!CalDueDate.Equals(that.CalDueDate)) return false;
            if (!ResultCheckBox.Equals(that.ResultCheckBox)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330Fluke)that);
        }
    }
}