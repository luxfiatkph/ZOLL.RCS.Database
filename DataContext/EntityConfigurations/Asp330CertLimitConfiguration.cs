﻿using System.Data.Entity.ModelConfiguration;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.EntityConfigurations
{
    /// <summary>
    /// This is the fluent configuration file for the <see cref="Asp330CertLimit"/> entity class
    /// Configuration files are used by Entity Framework to build queries
    /// </summary>
    public class Asp330CertLimitConfiguration : EntityTypeConfiguration<Asp330CertLimit>
    {
        public Asp330CertLimitConfiguration()
        {
            ToTable("ASP_330_CERT_LIMIT_DAYS");
            HasKey(k => k.UnitUnderTest);
            Property(p => p.UnitUnderTest)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("UNIT_UNDER_TEST");
            Property(p => p.CertLimitDays)
                .IsOptional()
                .HasColumnName("CERT_LIMIT_DAYS");
        }
    }
}