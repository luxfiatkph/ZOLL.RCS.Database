using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330TestLcdContrastSetRepository : Repository<Asp330TestLcdContrastSet, Guid>, IAsp330TestLcdContrastSetRepository
    {
        public Asp330TestLcdContrastSetRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestLcdContrastSets;
        }
    }
}