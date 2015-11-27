using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;
using com_facil_modulo_global.infra.data.Repositories.Nhibernate.Mappings;
using System.Configuration;

namespace com_facil_modulo_global_teste
{
    [TestClass]
    public class UnitTestDatabase: IDisposable
    {        
        private static ISessionFactory SessionFactory;
        protected ISession session;

        [TestInitialize]
        public void Initialize()
        {
            var connStr = ConfigurationManager.ConnectionStrings["com_facil_modulo_global_teste.Settings1.ConexaoModuloGlobal"].ConnectionString;
            SessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStr))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(TelefoneMap))))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(EnderecoMap))))
                .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(PessoaMap))))
                .BuildSessionFactory();

            session = SessionFactory.OpenSession();
        }

        [TestMethod]
        public void TestSelecionarPessoas()
        {            
        }

        public void Dispose()
        {
            session.Dispose();
        }
    }
}
