using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestConditionalPmDueResetRepository : Repository<Asp330TestConditionalPmDueReset, Guid>, IAsp330TestConditionalPmDueResetRepository
    {
        public Asp330TestConditionalPmDueResetRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestConditionalPmDueResets;
        }
    }
}