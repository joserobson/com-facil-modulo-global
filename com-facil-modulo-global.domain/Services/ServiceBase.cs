using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : Entidade
    {
        private readonly IRepositorio<TEntity> _repositorio;

        public ServiceBase(IRepositorio<TEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        [UnitOfWork]
        public IEnumerable<TEntity> GetAll()
        {
            /* Used UnitOfWork attribute, because GetAll method returns IQueryable<Person>, it does not fetches records from database. 
             * No database operation is performed until ToList(). Thus, we need to control connection open/close in this method using UnitOfWork. */
            return _repositorio.GetAll().ToList();
        }

        public TEntity Get(string id)
        {
            return _repositorio.Get(id);
        }

        public void Insert(TEntity entity)
        {
            _repositorio.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _repositorio.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            _repositorio.Delete(entity);
        }
    }
}
