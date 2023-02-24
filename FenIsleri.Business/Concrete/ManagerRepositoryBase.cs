using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Business.Abstract;
using FenIsleri.DataAccess.Abstract;
using FenIsleri.DataAccess.Concrete.EntityFramework;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Business.Concrete
{
    public class ManagerRepositoryBase<TEntity,TEntityDal>  
        where TEntity : class, IEntity, new() 
        where TEntityDal : IEntityRepository<TEntity>, new()
    {
        private TEntityDal _entityDal = new TEntityDal();
        public void Delete(TEntity entity)
        {
            _entityDal.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _entityDal.GetAll();
        }

        public void Add(TEntity entity)
        {
            _entityDal.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _entityDal.Update(entity);
        }
    }
}
