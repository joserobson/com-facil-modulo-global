using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Castle.Windsor;
using com_facil_modulo_global.application.AppServices;
using com_facil_modulo_global.infra.crosscutting.Dependency;
using Castle.Windsor.Installer;

namespace com_facil_modulo_global_teste
{
    [TestClass]
    public class UnitTestCliente
    {
        private WindsorContainer _windsorContainer;
        private IClienteAppService _clienteAppService;   

        [TestInitialize]
        public void Initialize()
        {
            _windsorContainer = new WindsorContainer();

            _windsorContainer.Install(FromAssembly.Containing<ComFacilModuloGlobalDependencyInstaller>());
            _windsorContainer.Install(FromAssembly.This());

            _clienteAppService = _windsorContainer.Resolve<IClienteAppService>();
        }

        [TestMethod]
        public void TestMethodCadastrarCliente()
        {

        }

        [TestMethod]
        public void TestObterClientes()
        {
            var clientes = _clienteAppService.ObterClientes();
        }
    }
}
