using System;
// ReSharper disable UnusedMember.Global
// ReSharper disable ConvertIfStatementToReturnStatement
#pragma warning disable 659

namespace ZOLL.RCS.Database.DataContext.Entities
{
    /// <summary>
    /// This class represents a record in the ASP_330_CERT_LIMIT_DAYS table
    /// </summary>
    public class Asp330CertLimit : IEquatable<Asp330CertLimit>
    {
        public string UnitUnderTest { get; set; }
        public short? CertLimitDays { get; set; }

        public Asp330CertLimit() { }

        public Asp330CertLimit(Asp330CertLimit that)
        {
            UnitUnderTest = that.UnitUnderTest;
            CertLimitDays = that.CertLimitDays;
        }

        public bool Equals(Asp330CertLimit that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (!UnitUnderTest.Equals(that.UnitUnderTest)) return false;
            if (!CertLimitDays.Equals(that.CertLimitDays)) return false;
            return true;
        }

        public override bool Equals(object that)
        {
            if (that is null) return false;
            if (ReferenceEquals(this, that)) return true;
            if (that.GetType() != GetType()) return false;
            return Equals((Asp330CertLimit)that);
        }
    }
}