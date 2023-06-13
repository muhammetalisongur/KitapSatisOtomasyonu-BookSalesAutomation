using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepostiory<TEntity> where TEntity : class,IEntity, new()
    {
        List<TEntity> GetAll(Func<TEntity, bool> filter = null);
        TEntity Get(Func<TEntity, bool> filter);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
