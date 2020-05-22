using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330SamRepository : Repository<Asp330Sam, Guid>, IAsp330SamRepository
    {
        public Asp330SamRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330Sams;
        }
    }
}