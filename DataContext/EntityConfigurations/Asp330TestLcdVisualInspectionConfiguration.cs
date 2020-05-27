using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330TestLcdVisualInspection"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestLcdVisualInspectionConfiguration : EntityTypeConfiguration<Asp330TestLcdVisualInspection>
    {
        public Asp330TestLcdVisualInspectionConfiguration()
        {
            ToTable("ASP_330_TEST_LCD_VISUAL_INSPECTION");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.LcdArtifactFree)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LCD_ARTIFACTFREE");
            Property(p => p.LcdBacklightEven)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LCD_BACKLIGHTEVEN");
            Property(p => p.LcdBlemishFree)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LCD_BLEMISHFREE");
            Property(p => p.LcdContrastGood)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("LCD_CONTRASTGOOD");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}