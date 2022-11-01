using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IGenericRepository<TEntity>
    {
        TEntity GetById(int id);
        TEntity Get(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties);
        TEntity GetOne(Expression<Func<TEntity, bool>> predicate = null);
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null);
        TEntity Add(TEntity entity);
        TEntity Update(TEntity entity);
        TEntity Delete(TEntity entity);
        int Count(Expression<Func<TEntity, bool>> predicate = null);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties);
    }
}
