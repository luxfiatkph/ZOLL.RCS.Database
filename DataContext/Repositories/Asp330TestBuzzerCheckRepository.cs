using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestBuzzerCheckRepository : Repository<Asp330TestBuzzerCheck, Guid>, IAsp330TestBuzzerCheckRepository
    {
        public Asp330TestBuzzerCheckRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestBuzzerChecks;
        }
    }
}