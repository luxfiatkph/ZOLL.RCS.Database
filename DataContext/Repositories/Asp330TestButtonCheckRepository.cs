using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestButtonCheckRepository : Repository<Asp330TestButtonCheck, Guid>, IAsp330TestButtonCheckRepository
    {
        public Asp330TestButtonCheckRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestButtonChecks;
        }
    }
}