using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestCommRamBootloadRepository : Repository<Asp330TestCommRamBootload, Guid>, IAsp330TestCommRamBootloadRepository
    {
        public Asp330TestCommRamBootloadRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestCommRamBootloads;
        }
    }
}