using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330FlukeRepository : Repository<Asp330Fluke, Guid>, IAsp330FlukeRepository
    {
        public Asp330FlukeRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330Flukes;
        }
    }

}
