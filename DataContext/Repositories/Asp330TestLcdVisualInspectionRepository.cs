﻿using System;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    /// <summary>
    /// This class is the repository for fetching, adding, and removing instances of <see cref="Asp330TestLcdVisualInspection"/>
    /// Typed repositories are built on the <see cref="Repository{TEntity,TKey}"/> class
    /// Each typed repository contains an Entities collection, a typed <see cref="System.Data.Entity.DbSet"/> of entities
    /// Each repository also contains a reference to the <see cref="TceContext"/> which is the wrapper for managing database transactions
    /// All repositories share the same instance of the <see cref="TceContext"/>
    /// </summary>
    public class Asp330TestLcdVisualInspectionRepository : Repository<Asp330TestLcdVisualInspection, Guid>, IAsp330TestLcdVisualInspectionRepository
    {
        public Asp330TestLcdVisualInspectionRepository(TceContext context) : base(context)
        {
            Entities = Context.Asp330TestLcdVisualInspections;
        }
    }
}