using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    public class Asp330TestCommRamBootloadConfiguration : EntityTypeConfiguration<Asp330TestCommRamBootload>
    {
        public Asp330TestCommRamBootloadConfiguration()
        {
            ToTable("ASP_330_TEST_COMM_RAM_BOOTLOAD");
            HasKey(k => k.Asp330TestId);

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.ResultCheckBox)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("RESULT_CHECK_BOX");
            Property(p => p.CheckPassedAspRam)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_ASPRAM");
            Property(p => p.CheckPassedSamComm)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_SAMCOMM");
            Property(p => p.CheckPassedAspComm)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_ASPCOMM");
            Property(p => p.CheckPassedAspWatchdog)
                .IsOptional()
                .HasColumnType("BIT")
                .HasColumnName("CHECK_PASSED_ASPWATCHDOG");
        }
    }
}