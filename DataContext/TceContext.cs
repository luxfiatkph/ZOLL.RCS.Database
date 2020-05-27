using System.Data.Entity;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.EntityConfigurations;

namespace ZOLL.RCS.Database.DataContext
{
    /// <summary>
    /// Database context - wrapper around <see cref="DbContext"/>
    /// This class manages the database connection itself
    /// </summary>
    public class TceContext : DbContext
    {
        public TceContext() : base("name=TceVentDb")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        #region Asp330 DbSets

        public virtual DbSet<Asp330CertLimit> Asp330CertLimits { get; set; }
        public virtual DbSet<Asp330CustomerCert> Asp330CustomerCerts { get; set; }
        public virtual DbSet<Asp330Device> Asp330Devices { get; set; }
        public virtual DbSet<Asp330Fluke> Asp330Flukes { get; set; }
        public virtual DbSet<Asp330Sam> Asp330Sams { get; set; }
        public virtual DbSet<Asp330SequenceTest> Asp330SequenceTests { get; set; }
        public virtual DbSet<Asp330Test> Asp330Tests { get; set; }
        public virtual DbSet<Asp330TestAspSelfCheck> Asp330TestAspSelfChecks { get; set; }
        public virtual DbSet<Asp330TestButtonCheck> Asp330TestButtonChecks { get; set; }
        public virtual DbSet<Asp330TestBuzzerCheck> Asp330TestBuzzerChecks { get; set; }
        public virtual DbSet<Asp330TestCommRamBootload> Asp330TestCommRamBootloads { get; set; }
        public virtual DbSet<Asp330TestConditionalPmDueReset> Asp330TestConditionalPmDueResets { get; set; }
        public virtual DbSet<Asp330TestDatetimeCheck> Asp330TestDatetimeChecks { get; set; }
        public virtual DbSet<Asp330TestLcdContrastSet> Asp330TestLcdContrastSets { get; set; }
        public virtual DbSet<Asp330TestLcdVisualInspection> Asp330TestLcdVisualInspections { get; set; }
        public virtual DbSet<Asp330TestLedCheck> Asp330TestLedChecks { get; set; }
        public virtual DbSet<Asp330TestLiIonBatteryCheck> Asp330TestLiIonBatteryChecks { get; set; }
        public virtual DbSet<Asp330TestTotalPowerFailureAlarm> Asp330TestTotalPowerFailureAlarms { get; set; }

        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Asp330CertLimitConfiguration());
            modelBuilder.Configurations.Add(new Asp330CustomerCertConfiguration());
            modelBuilder.Configurations.Add(new Asp330DeviceConfiguration());
            modelBuilder.Configurations.Add(new Asp330FlukeConfiguration());
            modelBuilder.Configurations.Add(new Asp330SamConfiguration());
            modelBuilder.Configurations.Add(new Asp330SequenceTestConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestAspSelfCheckConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestButtonCheckConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestBuzzerCheckConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestCommRamBootloadConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestConditionalPmDueResetConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestDatetimeCheckConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestLcdContrastSetConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestLcdVisualInspectionConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestLedCheckConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestLiIonBatteryCheckConfiguration());
            modelBuilder.Configurations.Add(new Asp330TestTotalPowerFailureAlarmConfiguration());
        }
    }
}