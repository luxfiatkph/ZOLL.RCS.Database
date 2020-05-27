using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330SequenceTest"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330SequenceTestConfiguration : EntityTypeConfiguration<Asp330SequenceTest>
    {
        public Asp330SequenceTestConfiguration()
        {
            ToTable("ASP_330_SEQUENCE_TESTS");
            HasKey(k => new { k.SequenceId, k.TestId });
            Property(p => p.SequenceId)
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("SEQUENCE_ID");
            Property(p => p.TestId)
                .IsRequired()
                .HasColumnOrder(1)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None)
                .HasColumnName("TEST_ID");
            Property(p => p.SequenceName)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SEQUENCE_NAME");
            Property(p => p.TestName)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_NAME");
            Property(p => p.TestTableName)
                .IsOptional()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TEST_TABLE_NAME");
        }
    }
}
