using System;
using System.Collections.Generic;
using Bogus;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataUnitTests
{
    public class FakerAsp330
    {
        public static List<Asp330CertLimit> Asp330CertLimitFaker(short certLimitDays, int quantity = 1)
        {
            var result = new Faker<Asp330CertLimit>()
                .RuleFor(p => p.UnitUnderTest, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.CertLimitDays, f => certLimitDays++);
            return result.Generate(quantity);
        }

        public static List<Asp330CustomerCert> Asp330CustomerCertFaker(DateTime date, int quantity = 1)
        {
            var i = 0;

            var result = new Faker<Asp330CustomerCert>()
                .RuleFor(p => p.Asp330CustomerCertId, f => Guid.NewGuid())
                .RuleFor(p => p.RcmId, f => Guid.NewGuid())
                .RuleFor(p => p.Asp330SystemTestId, f => Guid.NewGuid())
                .RuleFor(p => p.Asp330FinalConfigId, f => Guid.NewGuid())
                .RuleFor(p => p.Asp330Sn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.Asp330Model, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.SystemTestDate, f => new DateTime(date.Ticks).AddDays(i++).Date)
                .RuleFor(p => p.PmDueDate, f => new DateTime(date.Ticks).AddDays(i++).Date)
                .RuleFor(p => p.RecordCreationStamp, f => DateTime.Now);
            return result.Generate(quantity);
        }

        public static List<Asp330Device> Asp330DeviceFaker(int lcdContrast, int quantity = 1)
        {
            var result = new Faker<Asp330Device>()
                .RuleFor(p => p.Asp330TestId, f => Guid.NewGuid())
                .RuleFor(p => p.Asp330Sn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.Asp330Model, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.SamSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.LcdContrast, f => lcdContrast++)
                .RuleFor(p => p.CpuSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.UimSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.PimSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.Asp330Firmware, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.BootVersion, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.LangVersion, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.ConfigVersion, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.ConfigFileNumber, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.Note, f => f.Lorem.Sentences(1))
                .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
            return result.Generate(quantity);
        }

        public static List<Asp330Fluke> Asp330FlukeFaker(DateTime date, int quantity = 1)
        {
            var i = 0;

            var result = new Faker<Asp330Fluke>()
                .RuleFor(p => p.Asp330TestId, f => Guid.NewGuid())
                .RuleFor(p => p.FlukeSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.FlukeModel, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.DeviceVersion, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.CalDueDate, f => new DateTime(date.Ticks).AddDays(i++).Date)
                .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
            return result.Generate(quantity);
        }

        public static List<Asp330Sam> Asp330SamFaker(int minutes, int quantity = 1)
        {
            var result = new Faker<Asp330Sam>()
                .RuleFor(p => p.Asp330TestId, f => Guid.NewGuid())
                .RuleFor(p => p.SamSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.SamFirmware, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.MinsOfOp, f => minutes++)
                .RuleFor(p => p.PumpSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.SamBoardSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.LastCalDate, f => f.Date.Future().Date)
                .RuleFor(p => p.Note, f => f.Lorem.Sentences(1))
                .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
            return result.Generate(quantity);
        }

        public static List<Asp330SequenceTest> Asp330SequenceTestFaker(short sequenceId, short testId, int quantity = 1)
        {
            var result = new Faker<Asp330SequenceTest>()
                .RuleFor(p => p.SequenceId, f => sequenceId)
                .RuleFor(p => p.TestId, f => testId++)
                .RuleFor(p => p.SequenceName, f => f.Random.AlphaNumeric(20))
                .RuleFor(p => p.TestName, f => f.Random.AlphaNumeric(20))
                .RuleFor(p => p.TestTableName, f => f.Random.AlphaNumeric(20));
            return result.Generate(quantity);
        }

        public static List<Asp330Test> Asp330TestFaker(int quantity = 1)
        {
            var i = 0;
            var result = new Faker<Asp330Test>()
                .RuleFor(p => p.Asp330TestId, f => Guid.NewGuid())
                .RuleFor(p => p.Asp330Sn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.Asp330Model, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.SamSn, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.RcmId, f => Guid.NewGuid())
                .RuleFor(p => p.UserGuid, f => Guid.NewGuid())
                .RuleFor(p => p.TestType, f => i++)
                .RuleFor(p => p.TestSequenceName, f => f.Random.AlphaNumeric(15))
                .RuleFor(p => p.TestDate, f => f.Date.Recent())
                .RuleFor(p => p.Note, f => f.Lorem.Sentence())
                .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
            return result.Generate(quantity);
        }

        public static List<Asp330TestAspSelfCheck> Asp330TestAspSelfCheckFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestAspSelfCheck>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestAspSelfCheck>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.PassedPowerSelfCheck, f => f.Random.Bool())
                    .RuleFor(p => p.PassedCommSelfCheck, f => f.Random.Bool())
                    .RuleFor(p => p.PassedSamSelfCheck, f => f.Random.Bool())
                    .RuleFor(p => p.PassedTemperatureSelfCheck, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestButtonCheck> Asp330TestButtonCheckFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestButtonCheck>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestButtonCheck>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.CheckPassedSmartFlowOnButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedSmartFlowCalButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedModeButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedSelectConfirmButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedSurgicalButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedPharyngealButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedTrachealButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedCassButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedMenuButton, f => f.Random.Bool())
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedMuteCancelButton, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedStandbyButton, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestBuzzerCheck> Asp330TestBuzzerCheckFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestBuzzerCheck>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestBuzzerCheck>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestCommRamBootload> Asp330TestCommRamBootloadFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestCommRamBootload>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestCommRamBootload>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedAspRam, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedSamComm, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedAspComm, f => f.Random.Bool())
                    .RuleFor(p => p.CheckPassedAspWatchdog, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestConditionalPmDueReset> Asp330TestConditionalPmDueResetFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestConditionalPmDueReset>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestConditionalPmDueReset>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.PmDueResetRuntimeMinutes, f => f.Random.Int(1, 20))
                    .RuleFor(p => p.PmDueResetTotalMinute, f => f.Random.Int(1, 20))
                    .RuleFor(p => p.PmDueResetCalDate, f => f.Date.Future().Date)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestDatetimeCheck> Asp330TestDatetimeCheckFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestDatetimeCheck>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestDatetimeCheck>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.DatetimeCheckSamDate, f => f.Random.AlphaNumeric(15))
                    .RuleFor(p => p.DatetimeCheckSamTime, f => f.Random.AlphaNumeric(15))
                    .RuleFor(p => p.DatetimeCheckPcDate, f => f.Random.AlphaNumeric(15))
                    .RuleFor(p => p.DatetimeCheckPcTime, f => f.Random.AlphaNumeric(15))
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestLcdContrastSet> Asp330TestLcdContrastSetFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestLcdContrastSet>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestLcdContrastSet>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.SettingContrast, f => f.Random.Int(1, 200))
                    .RuleFor(p => p.SettingLowLimit, f => f.Random.Int(1, 200))
                    .RuleFor(p => p.SettingHighLimit, f => f.Random.Int(1, 200));
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestLcdVisualInspection> Asp330TestLcdVisualInspectionFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestLcdVisualInspection>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestLcdVisualInspection>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.LcdArtifactFree, f => f.Random.Bool())
                    .RuleFor(p => p.LcdBacklightEven, f => f.Random.Bool())
                    .RuleFor(p => p.LcdBlemishFree, f => f.Random.Bool())
                    .RuleFor(p => p.LcdContrastGood, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestLedCheck> Asp330TestLedCheckFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestLedCheck>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestLedCheck>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.LedCheckPassedYellow, f => f.Random.Bool())
                    .RuleFor(p => p.LedCheckPassedRed, f => f.Random.Bool())
                    .RuleFor(p => p.LedCheckPassedMuteButton, f => f.Random.Bool())
                    .RuleFor(p => p.LedCheckPassedIr, f => f.Random.Bool())
                    .RuleFor(p => p.LedCheckPassedGreen, f => f.Random.Bool())
                    .RuleFor(p => p.LedCheckPassedSelectButton, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestLiIonBatteryCheck> Asp330TestLiIonBatteryCheckFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestLiIonBatteryCheck>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestLiIonBatteryCheck>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool())
                    .RuleFor(p => p.ThresholdSecondsAboveCharge, f => f.Random.Int(1, 100))
                    .RuleFor(p => p.ThresholdSecondsAboveDischarge, f => f.Random.Int(1, 100))
                    .RuleFor(p => p.BatteryDischargeTestPassed, f => f.Random.Bool())
                    .RuleFor(p => p.BatteryChargeTestPassed, f => f.Random.Bool())
                    .RuleFor(p => p.BatteryAlarmsCheckPassed, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }

        public static List<Asp330TestTotalPowerFailureAlarm> Asp330TestTotalPowerFailureAlarmFaker(List<Guid> ids)
        {
            var result = new List<Asp330TestTotalPowerFailureAlarm>();
            foreach (var id in ids)
            {
                var entityFaker = new Faker<Asp330TestTotalPowerFailureAlarm>()
                    .RuleFor(p => p.Asp330TestId, f => id)
                    .RuleFor(p => p.PowerSwitchOn, f => f.Random.Bool())
                    .RuleFor(p => p.ResultCheckBox, f => f.Random.Bool());
                result.Add(entityFaker.Generate());
            }

            return result;
        }
    }
}