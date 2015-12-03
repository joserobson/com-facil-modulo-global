using com_facil_modulo_global.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public interface IServiceBase { }

    public interface IServiceBase<TEntity, TPrimaryKey> : IServiceBase where TEntity : Entidade<TPrimaryKey>
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(TPrimaryKey key);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
