using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestAspSelfCheckRepository : Repository<Asp330TestAspSelfCheck, Guid>, IAsp330TestAspSelfCheckRepository
    {
        public Asp330TestAspSelfCheckRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestAspSelfChecks;
        }
    }
}