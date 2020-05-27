using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330Device"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330DeviceConfiguration : EntityTypeConfiguration<Asp330Device>
    {
        public Asp330DeviceConfiguration()
        {
            ToTable("ASP_330_DEVICE");
            HasKey(k => k.Asp330TestId);
            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
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
            Property(p => p.SamSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAM_SN");
            Property(p => p.LcdContrast)
                .IsOptional()
                .HasColumnName("LCD_CONTRAST");
            Property(p => p.CpuSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CPU_SN");
            Property(p => p.UimSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("UIM_SN");
            Property(p => p.PimSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PIM_SN");
            Property(p => p.Asp330Firmware)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASP_330_FIRMWARE");
            Property(p => p.BootVersion)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("BOOT_VERSION");
            Property(p => p.LangVersion)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LANG_VERSION");
            Property(p => p.ConfigVersion)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CONFIG_VERSION");
            Property(p => p.ConfigFileNumber)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONFIG_FILE_NUMBER");
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