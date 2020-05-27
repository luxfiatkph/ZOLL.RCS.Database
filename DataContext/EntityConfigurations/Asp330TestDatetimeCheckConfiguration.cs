using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330TestDatetimeCheck"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestDatetimeCheckConfiguration : EntityTypeConfiguration<Asp330TestDatetimeCheck>
    {
        public Asp330TestDatetimeCheckConfiguration()
        {
            ToTable("ASP_330_TEST_DATETIME_CHECK");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.DatetimeCheckSamDate)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATETIME_CHECK_SAM_DATE");
            Property(p => p.DatetimeCheckSamTime)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DATETIME_CHECK_SAM_TIME");
            Property(p => p.DatetimeCheckPcDate)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DATETIME_CHECK_PC_DATE");
            Property(p => p.DatetimeCheckPcTime)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DATETIME_CHECK_PC_TIME");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}