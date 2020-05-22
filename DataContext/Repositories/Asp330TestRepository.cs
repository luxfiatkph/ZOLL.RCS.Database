using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestRepository : Repository<Asp330Test, Guid>, IAsp330TestRepository
    {
        public Asp330TestRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330Tests;
        }
    }
}