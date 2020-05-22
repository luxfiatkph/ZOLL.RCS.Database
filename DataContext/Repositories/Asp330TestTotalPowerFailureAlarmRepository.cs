using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestTotalPowerFailureAlarmRepository : Repository<Asp330TestTotalPowerFailureAlarm, Guid>, IAsp330TestTotalPowerFailureAlarmRepository
    {
        public Asp330TestTotalPowerFailureAlarmRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestTotalPowerFailureAlarms;
        }
    }
}