using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    public class Asp330TestConditionalPmDueResetConfiguration : EntityTypeConfiguration<Asp330TestConditionalPmDueReset>
    {
        public Asp330TestConditionalPmDueResetConfiguration()
        {
            ToTable("ASP_330_TEST_CONDITIONAL_PM_DUE_RESET");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.PmDueResetRuntimeMinutes)
                .IsOptional()
                .HasColumnName("PM_DUE_RESET_RUNTIME_MINUTES");
            Property(p => p.PmDueResetTotalMinute)
                .IsOptional()
                .HasColumnName("PM_DUE_RESET_TOTAL_MINUTE");
            Property(p => p.PmDueResetCalDate)
                .IsOptional()
                .HasColumnType("DATETIME")
                .HasColumnName("PM_DUE_RESET_CAL_DATE");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}