using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330CertLimitRepository : Repository<Asp330CertLimit, string>, IAsp330CertLimitRepository
    {
        public Asp330CertLimitRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330CertLimits;
        }
    }
}