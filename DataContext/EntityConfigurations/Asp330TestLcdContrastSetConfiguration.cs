using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    public class Asp330TestLcdContrastSetConfiguration : EntityTypeConfiguration<Asp330TestLcdContrastSet>
    {
        public Asp330TestLcdContrastSetConfiguration()
        {
            ToTable("ASP_330_TEST_LCD_CONTRAST_SET");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.SettingContrast)
                .IsOptional()
                .HasColumnName("SETTING_CONTRAST");
            Property(p => p.SettingLowLimit)
                .IsOptional()
                .HasColumnName("SETTING_LOW_LIMIT");
            Property(p => p.SettingHighLimit)
                .IsOptional()
                .HasColumnName("SETTING_HIGH_LIMIT");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}