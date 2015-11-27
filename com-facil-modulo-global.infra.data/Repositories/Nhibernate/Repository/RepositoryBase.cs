using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Repository;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace com_facil_modulo_global.infra.data.Repositories.Nhibernate.Repository
{
    public abstract class RepositorioBase<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey> where TEntity : Entidade<TPrimaryKey>
    {
        protected ISession Session { get { return UnitOfWork.Current.Session; } }

        public IQueryable<TEntity> GetAll()
        {
            return Session.Query<TEntity>();
        }

        public TEntity Get(TPrimaryKey key)
        {
            return Session.Get<TEntity>(key);
        }

        public void Insert(TEntity entity)
        {
            Session.Save(entity);
        }

        public void Update(TEntity entity)
        {
            Session.Update(entity);
        }

        public void Delete(TEntity entity)
        {
            Session.Delete(entity);
        }
    }
}
