using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    public class Asp330TestAspSelfCheckConfiguration : EntityTypeConfiguration<Asp330TestAspSelfCheck>
    {
        public Asp330TestAspSelfCheckConfiguration()
        {
            ToTable("ASP_330_TEST_ASP_SELF_CHECK");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
            Property(p => p.PassedPowerSelfCheck)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("PASSED_POWERSELFCHECK");
            Property(p => p.PassedCommSelfCheck)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("PASSED_COMMSELFCHECK");
            Property(p => p.PassedSamSelfCheck)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("PASSED_SAMSELFCHECK");
            Property(p => p.PassedTemperatureSelfCheck)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("PASSED_TEMPERATURESELFCHECK");
        }
    }
}