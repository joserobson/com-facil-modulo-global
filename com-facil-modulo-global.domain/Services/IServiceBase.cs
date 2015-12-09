using com_facil_modulo_global.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public interface IServiceBase { }

    public interface IServiceBase<TEntity> : IServiceBase where TEntity : Entidade
    {
        IEnumerable<TEntity> GetAll();

        TEntity Get(string id);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
