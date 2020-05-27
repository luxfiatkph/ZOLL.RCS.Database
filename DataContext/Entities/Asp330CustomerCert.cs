using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_CUSTOMER_CERT table
    /// </summary>
    public class Asp330CustomerCert : IEquatable<Asp330CustomerCert>
    {
        public Guid Asp330CustomerCertId { get; set; }
        public Guid? RcmId { get; set; }
        public Guid? Asp330SystemTestId { get; set; }
        public Guid? Asp330FinalConfigId { get; set; }
        public string Asp330Sn { get; set; }
        public string Asp330Model { get; set; }
        public DateTime? SystemTestDate { get; set; }
        public DateTime? PmDueDate { get; set; }
        public DateTime? RecordCreationStamp { get; set; }

        public Asp330CustomerCert() { }

        public Asp330CustomerCert(Asp330CustomerCert that)
        {
            Asp330CustomerCertId = that.Asp330CustomerCertId;
            RcmId = that.RcmId;
            Asp330SystemTestId = that.Asp330SystemTestId;
            Asp330FinalConfigId = that.Asp330FinalConfigId;
            Asp330Sn = that.Asp330Sn;
            Asp330Model = that.Asp330Model;
            SystemTestDate = that.SystemTestDate;
            PmDueDate = that.PmDueDate;
            RecordCreationStamp = that.RecordCreationStamp;
        }

        public bool Equals(Asp330CustomerCert that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!Asp330CustomerCertId.Equals(that.Asp330CustomerCertId)) return false;
            if (!RcmId.Equals(that.RcmId)) return false;
            if (!Asp330SystemTestId.Equals(that.Asp330SystemTestId)) return false;
            if (!Asp330FinalConfigId.Equals(that.Asp330FinalConfigId)) return false;
            if (!Asp330Sn.Equals(that.Asp330Sn)) return false;
            if (!Asp330Model.Equals(that.Asp330Model)) return false;
            if (!SystemTestDate.Equals(that.SystemTestDate)) return false;
            if (!PmDueDate.Equals(that.PmDueDate)) return false;
            if (!RecordCreationStamp.Equals(that.RecordCreationStamp)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330CustomerCert)that);
        }
    }
}