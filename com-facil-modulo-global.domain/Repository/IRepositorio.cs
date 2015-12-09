using com_facil_modulo_global.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Repository
{
    public interface IRepositorio { }
    
    public interface IRepositorio<TEntity>: IRepositorio where TEntity: Entidade
    {
        IQueryable<TEntity> GetAll();

        TEntity Get(string key);

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);
    }
}
