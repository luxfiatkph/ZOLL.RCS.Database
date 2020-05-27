using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330TestTotalPowerFailureAlarm"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestTotalPowerFailureAlarmConfiguration : EntityTypeConfiguration<Asp330TestTotalPowerFailureAlarm>
    {
        public Asp330TestTotalPowerFailureAlarmConfiguration()
        {
            ToTable("ASP_330_TEST_TOTAL_POWER_FAILURE_ALARM");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
            Property(p => p.PowerSwitchOn)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("POWER_SWITCH_ON");
        }
    }
}