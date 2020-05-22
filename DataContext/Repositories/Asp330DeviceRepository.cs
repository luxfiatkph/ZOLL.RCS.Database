using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330DeviceRepository : Repository<Asp330Device, Guid>, IAsp330DeviceRepository
    {
        public Asp330DeviceRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330Devices;
        }
    }
}