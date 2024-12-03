using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MatchLeauge.DAL.IRepository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {

        IQueryable<TEntity> GetAll();
        //IQueryable<TEntity> FindAll();
        TEntity GetById(int Id);

        //void Add(TEntity entity);
        //void Update(TEntity entity);
        //void Delete(TEntity entity);

        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        //
        //IQueryable<TEntity> FindAll();
        //player.Where(p=>p.Adi=="Arda").ToList();
        IQueryable<TEntity> FindAll(Expression<Func<TEntity,bool>> predicate);


    }
}
