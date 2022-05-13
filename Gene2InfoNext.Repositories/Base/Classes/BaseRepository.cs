using Gene2InfoNext.Entities.Base;
using Gene2InfoNext.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gene2InfoNext.Repositories.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        public void Add(TEntity instance)
        {
            throw new NotImplementedException();
        }
        public int Deleted(int id)
        {
            throw new NotImplementedException();
        }
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }
        public TEntity Update(TEntity instance)
        {
            throw new NotImplementedException();
        }
    }
}
