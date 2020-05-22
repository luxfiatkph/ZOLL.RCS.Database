using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    public class Asp330TestBuzzerCheckConfiguration : EntityTypeConfiguration<Asp330TestBuzzerCheck>
    {
        public Asp330TestBuzzerCheckConfiguration()
        {
            ToTable("ASP_330_TEST_BUZZER_CHECK");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
        }
    }
}