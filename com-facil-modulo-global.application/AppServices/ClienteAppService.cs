using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.application.AppServices
{
    public class ClienteAppService: IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
        {
            this._clienteService = clienteService;
        }

        public void CadastrarCliente(Cliente cliente)
        {
            this._clienteService.Insert(cliente);   
        }

        public List<Cliente> ObterClientes()
        {
            return this._clienteService.GetAll().ToList();
        }
    }
}
