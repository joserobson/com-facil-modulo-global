using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NHibernate;
using NHibernate.Cfg;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;
using com_facil_modulo_global.infra.data.Repositories.Nhibernate.Mappings;
using System.Configuration;
using com_facil_modulo_global.domain.Services;
using com_facil_modulo_global.domain.Repository;
using com_facil_modulo_global.infra.data.Repositories.Nhibernate.Repository;

namespace com_facil_modulo_global_teste
{
    [TestClass]
    public class UnitTestPessoa
    {        
        ///private static ISessionFactory SessionFactory;
        //protected ISession session;

        private IPessoaService _pessoaService;
        private IPessoaRepositorio _pessoaRepositorio;

        //public UnitTestPessoa(IPessoaService pessoaService)
        //{
          //  _pessoaService = pessoaService;
        //}

        [TestInitialize]
        public void Initialize()
        {
            using (var moduloGlobalRunner = new ModuloGlobalRunner())
            {
                moduloGlobalRunner.Start();

                //Console.WriteLine("Press enter to stop background services...");
                //Console.ReadLine();
            }
        }


        //[TestInitialize]
        //public void Initialize()
        //{
        //    var connStr = ConfigurationManager.ConnectionStrings["com_facil_modulo_global_teste.Settings1.ConexaoModuloGlobal"].ConnectionString;
        //    SessionFactory = Fluently.Configure()
        //        .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connStr))
        //        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(TelefoneMap))))
        //        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(EnderecoMap))))
        //        .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetAssembly(typeof(PessoaMap))))
        //        .BuildSessionFactory();

        //    session = SessionFactory.OpenSession();
        //}

        [TestMethod]
        public void TestSelecionarPessoas()
        {
            _pessoaRepositorio = new PessoaRepositorio();
            _pessoaService = new PessoaService(_pessoaRepositorio);
            var lista = _pessoaService.ObterListaPessoa();
            Assert.IsNotNull(lista);
        }

        //public void Dispose()
        //{
        //    session.Dispose();
        //}
    }
}
