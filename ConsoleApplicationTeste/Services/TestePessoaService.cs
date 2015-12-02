using com_facil_modulo_global.domain.Repository;
using com_facil_modulo_global.domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTeste.Services
{
    public class TestePessoaService: ITestePessoaService
    {        
        private readonly IPessoaService _personService;

        public TestePessoaService( IPessoaService pessoaService)
        {            
            _personService = pessoaService;
        }

        public void ObterPessoas()
        {
            var lista = _personService.ObterListaPessoa();   
        }
    }
}
