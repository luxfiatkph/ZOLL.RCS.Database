using System;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext
{
    public interface IUnitOfWork : IDisposable
    {
        IAsp330CertLimitRepository Asp330CertLimits { get; }
        IAsp330CustomerCertRepository Asp330CustomerCerts { get; }
        IAsp330DeviceRepository Asp330Devices { get; }
        IAsp330FlukeRepository Asp330Flukes { get; }
        IAsp330SamRepository Asp330Sams { get; }
        IAsp330SequenceTestRepository Asp330SequenceTests { get; }
        IAsp330TestRepository Asp330Tests { get; }
        IAsp330TestAspSelfCheckRepository Asp330TestAspSelfChecks { get; }
        IAsp330TestButtonCheckRepository Asp330TestButtonChecks { get; }
        IAsp330TestBuzzerCheckRepository Asp330TestBuzzerChecks { get; }
        IAsp330TestCommRamBootloadRepository Asp330TestCommRamBootloads { get; }
        IAsp330TestConditionalPmDueResetRepository Asp330TestConditionalPmDueResets { get; }
        IAsp330TestDatetimeCheckRepository Asp330TestDatetimeChecks { get; }
        IAsp330TestLcdContrastSetRepository Asp330TestLcdContrastSets { get; }
        IAsp330TestLcdVisualInspectionRepository Asp330TestLcdVisualInspections { get; }
        IAsp330TestLedCheckRepository Asp330TestLedChecks { get; }
        IAsp330TestLiIonBatteryCheckRepository Asp330TestLiIonBatteryChecks { get; }
        IAsp330TestTotalPowerFailureAlarmRepository Asp330TestTotalPowerFailureAlarms { get; }
        int SaveChanges();
    }
}