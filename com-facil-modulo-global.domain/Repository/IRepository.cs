using com_facil_modulo_global.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Repository
{
    public interface IRepository { }
    
    public interface IRepository<TEntity, TPrimaryKey>: IRepository where TEntity: Entidade<TPrimaryKey>
    {
        IQueryable<TEntity> GetAll();

        TEntity Get(TPrimaryKey key);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
