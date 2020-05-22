using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using ZOLL.RCS.Database.DataContext.Entities;

namespace ZOLL.RCS.Database.DataContext.RepositoryInterfaces
{
    public interface IAsp330SequenceTestRepository
    {
        DbSet<Asp330SequenceTest> Entities { get; set; }
        Asp330SequenceTest Get(short sequenceId, short testId);
        IEnumerable<Asp330SequenceTest> GetAll();
        IEnumerable<Asp330SequenceTest> GetByTestId(short testId);
        IEnumerable Find(Expression<Func<Asp330SequenceTest, bool>> predicate);
        void Add(Asp330SequenceTest entity);
        void AddRange(IEnumerable<Asp330SequenceTest> entities);
        void Remove(Asp330SequenceTest entity);
        void RemoveRange(IEnumerable<Asp330SequenceTest> entities);
    }
}