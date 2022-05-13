using Gene2InfoNext.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gene2InfoNext.Repositories.Base.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        void Add(TEntity instance);
        TEntity Update(TEntity instance);
        int Deleted(int id);
        TEntity Get(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(int id);

    }
}
