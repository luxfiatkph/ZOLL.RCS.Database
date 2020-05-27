using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330TestButtonCheck"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestButtonCheckConfiguration : EntityTypeConfiguration<Asp330TestButtonCheck>
    {
        public Asp330TestButtonCheckConfiguration()
        {
            ToTable("ASP_330_TEST_BUTTON_CHECK");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.CheckPassedSmartFlowOnButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_SMARTFLOWONBUTTON");
            Property(p => p.CheckPassedSmartFlowCalButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_SMARTFLOWCALBUTTON");
            Property(p => p.CheckPassedModeButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_MODEBUTTON");
            Property(p => p.CheckPassedSelectConfirmButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_SELECTCONFIRMBUTTON");
            Property(p => p.CheckPassedSurgicalButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_SURGICALBUTTON");
            Property(p => p.CheckPassedPharyngealButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_PHARYNGEALBUTTON");
            Property(p => p.CheckPassedTrachealButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_TRACHEALBUTTON");
            Property(p => p.CheckPassedCassButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_CASSBUTTON");
            Property(p => p.CheckPassedMenuButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_MENUBUTTON");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
            Property(p => p.CheckPassedMuteCancelButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_MUTECANCELBUTTON");
            Property(p => p.CheckPassedStandbyButton)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_STANDBYBUTTON");
        }
    }
}