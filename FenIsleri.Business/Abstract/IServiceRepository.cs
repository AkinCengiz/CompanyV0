using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.DataAccess.Abstract;
using FenIsleri.Entities.Abstract;

namespace FenIsleri.Business.Abstract
{
    public interface IServiceRepository<TRepository,TEntity> 
        where TRepository : class ,IEntityRepository<TEntity>, new() 
        where TEntity : class, IEntity, new()
    {
        List<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
