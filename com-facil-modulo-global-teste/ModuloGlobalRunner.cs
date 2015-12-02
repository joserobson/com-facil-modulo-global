using Castle.Windsor;
using Castle.Windsor.Installer;
using com_facil_modulo_global.infra.crosscutting.Dependency;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global_teste
{
    public class ModuloGlobalRunner: IDisposable
    {
        private WindsorContainer _windsorContainer;

        public void Start()
        {
            _windsorContainer = new WindsorContainer();

            _windsorContainer.Install(FromAssembly.Containing<ComFacilModuloGlobalDependencyInstaller>());
            _windsorContainer.Install(FromAssembly.This());

            //_windsorContainer.Resolve<IPeriodicServiceTrigger>().Start();
        }

        public void Dispose()
        {
            if (_windsorContainer != null)
            {
                //_windsorContainer.Resolve<IPeriodicServiceTrigger>().Stop();
                _windsorContainer.Dispose();
            }
        }
    }
}
