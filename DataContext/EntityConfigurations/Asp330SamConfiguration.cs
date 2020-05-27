using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330Sam"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330SamConfiguration : EntityTypeConfiguration<Asp330Sam>
    {
        public Asp330SamConfiguration()
        {
            ToTable("ASP_330_SAM");
            HasKey(k => k.Asp330TestId);
            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.SamSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAM_SN");
            Property(p => p.SamFirmware)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAM_FIRMWARE");
            Property(p => p.MinsOfOp)
                .IsOptional()
                .HasColumnName("MINS_OF_OP");
            Property(p => p.PumpSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PUMP_SN");
            Property(p => p.SamBoardSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAM_BOARD_SN");
            Property(p => p.LastCalDate)
                .IsOptional()
                .HasColumnType("DATE")
                .HasColumnName("LAST_CAL_DATE");
            Property(p => p.Note)
                .IsOptional()
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("NOTE");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}