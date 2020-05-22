using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    public class Asp330CustomerCertConfiguration : EntityTypeConfiguration<Asp330CustomerCert>
    {
        public Asp330CustomerCertConfiguration()
        {
            ToTable("ASP_330_CUSTOMER_CERT");
            HasKey(k => k.Asp330CustomerCertId);
            Property(p => p.Asp330CustomerCertId)
                .IsRequired()
                .HasColumnName("ASP_330_CUSTOMER_CERT_ID");
            Property(p => p.RcmId)
                .IsOptional()
                .HasColumnName("RCM_ID");
            Property(p => p.Asp330SystemTestId)
                .IsOptional()
                .HasColumnName("ASP_330_SYSTEM_TEST_ID");
            Property(p => p.Asp330FinalConfigId)
                .IsOptional()
                .HasColumnName("ASP_330_FINALCONFIG_ID");
            Property(p => p.Asp330Sn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASP_330_SN");
            Property(p => p.Asp330Model)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASP_330_MODEL");
            Property(p => p.SystemTestDate)
                .IsOptional()
                .HasColumnType("DATETIME")
                .HasColumnName("SYSTEM_TEST_DATE");
            Property(p => p.PmDueDate)
                .IsOptional()
                .HasColumnType("DATETIME")
                .HasColumnName("PM_DUE_DATE");
            Property(p => p.RecordCreationStamp)
                .IsOptional()
                .HasColumnType("DATETIME")
                .HasColumnName("RECORD_CREATION_STAMP");
        }
    }
}