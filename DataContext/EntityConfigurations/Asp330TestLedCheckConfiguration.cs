using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330TestLedCheck"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestLedCheckConfiguration : EntityTypeConfiguration<Asp330TestLedCheck>
    {
        public Asp330TestLedCheckConfiguration()
        {
            ToTable("ASP_330_TEST_LED_CHECK");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
            Property(p => p.LedCheckPassedYellow)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LED_CHECK_PASSED_YELLOW");
            Property(p => p.LedCheckPassedRed)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LED_CHECK_PASSED_RED");
            Property(p => p.LedCheckPassedMuteButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LED_CHECK_PASSED_MUTEBUTTON");
            Property(p => p.LedCheckPassedIr)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LED_CHECK_PASSED_IR");
            Property(p => p.LedCheckPassedGreen)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LED_CHECK_PASSED_GREEN");
            Property(p => p.LedCheckPassedSelectButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LED_CHECK_PASSED_SELECTBUTTON");
        }
    }
}