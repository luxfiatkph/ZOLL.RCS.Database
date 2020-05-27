using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330Fluke"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330FlukeConfiguration : EntityTypeConfiguration<Asp330Fluke>
    {
        public Asp330FlukeConfiguration()
        {
            ToTable("ASP_330_FLUKE");
            HasKey(k => k.Asp330TestId);
            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.FlukeSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLUKE_SN");
            Property(p => p.FlukeModel)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FLUKE_MODEL");
            Property(p => p.DeviceVersion)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DEVICE_VERSION");
            Property(p => p.CalDueDate)
                .IsOptional()
                .HasColumnType("DATE")
                .HasColumnName("CAL_DUE_DATE");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}