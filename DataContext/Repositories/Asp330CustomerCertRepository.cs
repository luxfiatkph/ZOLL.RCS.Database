using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330CustomerCertRepository : Repository<Asp330CustomerCert, Guid>, IAsp330CustomerCertRepository
    {
        public Asp330CustomerCertRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330CustomerCerts;
        }
    }
}