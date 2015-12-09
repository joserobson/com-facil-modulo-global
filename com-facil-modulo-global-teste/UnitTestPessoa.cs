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
using Castle.Windsor;
using Castle.Windsor.Installer;
using com_facil_modulo_global.infra.crosscutting.Dependency;
using com_facil_modulo_global.application.AppServices;

namespace com_facil_modulo_global_teste
{
    [TestClass]
    public class UnitTestPessoa : IDisposable
    {                
        private WindsorContainer _windsorContainer;

        private IPessoaAppService _pessoaService;                

        [TestInitialize]
        public void Initialize()
        {
            _windsorContainer = new WindsorContainer();

            _windsorContainer.Install(FromAssembly.Containing<ComFacilModuloGlobalDependencyInstaller>());
            _windsorContainer.Install(FromAssembly.This());

            _pessoaService = _windsorContainer.Resolve<IPessoaAppService>();
        }
     

        [TestMethod]
        public void TestSelecionarPessoas()
        {
            var lista = _pessoaService.ObterPessoas();
            
        }

        public void Dispose()
        {
            if (_windsorContainer != null)
            {                
                _windsorContainer.Dispose();
            }
        }
    }
}
