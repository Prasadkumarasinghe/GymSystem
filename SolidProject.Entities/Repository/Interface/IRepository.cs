using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SolidProject.Entities.Repository.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entityList);

        void Delete(TEntity entity);
        void DeletRange(IEnumerable<TEntity> entityList);

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        Task<TEntity> GetAsync(int id);
        Task<IEnumerable<TEntity>> GetAllAsync();

        void Update(TEntity entity);
    }
}
