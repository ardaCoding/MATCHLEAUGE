using MatchLeauge.DAL.IRepository;
using MatchLeauge.DAL.MLContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.BLL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly MatchLeagueDB _matchLeagueDB;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(MatchLeagueDB matchLeagueDB)//DI
        {
            _matchLeagueDB = matchLeagueDB;
            _dbSet =_matchLeagueDB.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            //return _matchLeagueDB.Set<TEntity>().AsQueryable();
            var list= _dbSet.AsQueryable();

            return list;
        }


        public TEntity GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
