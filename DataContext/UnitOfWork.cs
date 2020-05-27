using ZOLL.RCS.Database.DataContext.Repositories;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext
{
    /// <summary>
    /// This is the transaction manager for the context. A shared copy of a single instance
    /// of the context is inserted into each repository. All of the Repositories can be accessed
    /// through this class
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TceContext _context;

        public UnitOfWork(TceContext context)
        {
            _context = context;
            Asp330CertLimits = new Asp330CertLimitRepository(_context);
            Asp330CustomerCerts = new Asp330CustomerCertRepository(_context);
            Asp330Devices = new Asp330DeviceRepository(_context);
            Asp330Flukes = new Asp330FlukeRepository(_context);
            Asp330Sams = new Asp330SamRepository(_context);
            Asp330SequenceTests = new Asp330SequenceTestRepository(_context);
            Asp330Tests = new Asp330TestRepository(_context);
            Asp330TestAspSelfChecks = new Asp330TestAspSelfCheckRepository(_context);
            Asp330TestButtonChecks = new Asp330TestButtonCheckRepository(_context);
            Asp330TestBuzzerChecks = new Asp330TestBuzzerCheckRepository(_context);
            Asp330TestCommRamBootloads = new Asp330TestCommRamBootloadRepository(_context);
            Asp330TestConditionalPmDueResets = new Asp330TestConditionalPmDueResetRepository(_context);
            Asp330TestDatetimeChecks = new Asp330TestDatetimeCheckRepository(_context);
            Asp330TestLcdContrastSets = new Asp330TestLcdContrastSetRepository(_context);
            Asp330TestLcdVisualInspections = new Asp330TestLcdVisualInspectionRepository(_context);
            Asp330TestLedChecks = new Asp330TestLedCheckRepository(_context);
            Asp330TestLiIonBatteryChecks = new Asp330TestLiIonBatteryCheckRepository(_context);
            Asp330TestTotalPowerFailureAlarms = new Asp330TestTotalPowerFailureAlarmRepository(_context);
        }

        public IAsp330CertLimitRepository Asp330CertLimits { get; }
        public IAsp330CustomerCertRepository Asp330CustomerCerts { get; }
        public IAsp330DeviceRepository Asp330Devices { get; }
        public IAsp330FlukeRepository Asp330Flukes { get; }
        public IAsp330SamRepository Asp330Sams { get; }
        public IAsp330SequenceTestRepository Asp330SequenceTests { get; }
        public IAsp330TestRepository Asp330Tests { get; }
        public IAsp330TestAspSelfCheckRepository Asp330TestAspSelfChecks { get; }
        public IAsp330TestButtonCheckRepository Asp330TestButtonChecks { get; }
        public IAsp330TestBuzzerCheckRepository Asp330TestBuzzerChecks { get; }
        public IAsp330TestCommRamBootloadRepository Asp330TestCommRamBootloads { get; }
        public IAsp330TestConditionalPmDueResetRepository Asp330TestConditionalPmDueResets { get; }
        public IAsp330TestDatetimeCheckRepository Asp330TestDatetimeChecks { get; }
        public IAsp330TestLcdContrastSetRepository Asp330TestLcdContrastSets { get; }
        public IAsp330TestLcdVisualInspectionRepository Asp330TestLcdVisualInspections { get; }
        public IAsp330TestLedCheckRepository Asp330TestLedChecks { get; }
        public IAsp330TestLiIonBatteryCheckRepository Asp330TestLiIonBatteryChecks { get; }
        public IAsp330TestTotalPowerFailureAlarmRepository Asp330TestTotalPowerFailureAlarms { get; }

        public int SaveChanges()
        {
            return  _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}