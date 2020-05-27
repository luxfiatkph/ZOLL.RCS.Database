using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestLiIonBatteryCheckRepository : Repository<Asp330TestLiIonBatteryCheck, Guid>, IAsp330TestLiIonBatteryCheckRepository
    {
        public Asp330TestLiIonBatteryCheckRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestLiIonBatteryChecks;
        }
    }
}