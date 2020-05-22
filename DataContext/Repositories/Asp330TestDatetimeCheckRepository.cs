using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestDatetimeCheckRepository : Repository<Asp330TestDatetimeCheck, Guid>, IAsp330TestDatetimeCheckRepository
    {
        public Asp330TestDatetimeCheckRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestDatetimeChecks;
        }
    }
}