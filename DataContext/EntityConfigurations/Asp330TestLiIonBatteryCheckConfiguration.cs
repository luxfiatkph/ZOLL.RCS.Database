using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330TestLiIonBatteryCheck"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestLiIonBatteryCheckConfiguration : EntityTypeConfiguration<Asp330TestLiIonBatteryCheck>
    {
        public Asp330TestLiIonBatteryCheckConfiguration()
        {
            ToTable("ASP_330_TEST_LI_ION_BATTERY_CHECK");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
            Property(p => p.ThresholdSecondsAboveCharge)
                .IsOptional()
                .HasColumnName("THRESHOLD_SECONDSABOVECHARGE");
            Property(p => p.ThresholdSecondsAboveDischarge)
                .IsOptional()
                .HasColumnName("THRESHOLD_SECONDSABOVEDISCHARGE");
            Property(p => p.BatteryDischargeTestPassed)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("BATTERY_DISCHARGETESTPASSED");
            Property(p => p.BatteryChargeTestPassed)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("BATTERY_CHARGETESTPASSED");
            Property(p => p.BatteryAlarmsCheckPassed)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("BATTERY_ALARMSCHECKPASSED");
        }
    }
}