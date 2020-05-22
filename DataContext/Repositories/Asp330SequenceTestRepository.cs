using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using ZOLL.RCS.Database.DataContext.Entities;
using ZOLL.RCS.Database.DataContext.RepositoryInterfaces;

namespace ZOLL.RCS.Database.DataContext.Repositories
{
    public class Asp330SequenceTestRepository : IAsp330SequenceTestRepository
    {
        protected TceContext Context { get; }
        public DbSet<Asp330SequenceTest> Entities { get; set; }

        public Asp330SequenceTestRepository(TceContext context)
        {
            Context = context;
            Entities = Context.Asp330SequenceTests;
        }

        public Asp330SequenceTest Get(short sequenceId, short testId)
        {
            return Entities.Find(sequenceId, testId);
        }

        public IEnumerable<Asp330SequenceTest> GetAll()
        {
            return Entities.ToList();
        }

        public IEnumerable<Asp330SequenceTest> GetByTestId(short testId)
        {
            return Entities.Include(f => f.TestId == testId).OrderBy(f => f.SequenceId).ToList();
        }

        public IEnumerable Find(Expression<Func<Asp330SequenceTest, bool>> predicate)
        {
            return Entities.Where(predicate);
        }

        public void Add(Asp330SequenceTest entity)
        {
            Entities.Add(entity);
        }

        public void AddRange(IEnumerable<Asp330SequenceTest> entities)
        {
            Entities.AddRange(entities);
        }

        public void Remove(Asp330SequenceTest entity)
        {
            Entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Asp330SequenceTest> entities)
        {
            Entities.RemoveRange(entities);
        }
    }
}