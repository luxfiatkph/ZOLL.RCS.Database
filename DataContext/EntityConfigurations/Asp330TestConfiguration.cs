using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330Test"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330TestConfiguration : EntityTypeConfiguration<Asp330Test>
    {
        public Asp330TestConfiguration()
        {
            ToTable("ASP_330_TEST");
            HasKey(k => k.Asp330TestId);
            HasOptional(x => x.Asp330TestAspSelfCheck)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestButtonCheck)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestBuzzerCheck)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestCommRamBootload)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestConditionalPmDueReset)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestDatetimeCheck)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestLcdContrastSet)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestLcdVisualInspection)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestLedCheck)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestTotalPowerFailureAlarm)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();
            HasOptional(x => x.Asp330TestLiIonBatteryCheck)
                .WithRequired(x => x.Asp330Test)
                .WillCascadeOnDelete();

            Property(p => p.Asp330TestId)
                .IsRequired()
                .HasColumnName("ASP_330_TEST_ID");
            Property(p => p.Asp330Model)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASP_330_MODEL");
            Property(p => p.Asp330Sn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ASP_330_SN");
            Property(p => p.SamSn)
                .IsOptional()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SAM_SN");
            Property(p => p.RcmId)
                .IsOptional()
                .HasColumnName("RCM_ID");
            Property(p => p.UserGuid)
                .IsOptional()
                .HasColumnName("USER_GUID");
            Property(p => p.TestType)
                .IsOptional()
                .HasColumnName("TEST_TYPE");
            Property(p => p.TestSequenceName)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_SEQUENCE_NAME");
            Property(p => p.TestDate)
                .IsOptional()
                .HasColumnType("DATETIME")
                .HasColumnName("TEST_DATE");
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