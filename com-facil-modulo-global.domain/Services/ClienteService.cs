using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public class ClienteService:ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteService(IClienteRepositorio clienteRepositorio):base(clienteRepositorio)
        {
            this._clienteRepositorio = clienteRepositorio;
        }

    }
}
