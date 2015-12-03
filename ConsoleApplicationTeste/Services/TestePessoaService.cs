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
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public TestePessoaService( IPessoaService pessoaService, IPessoaFisicaService pessoaFisicaService)
        {            
            _personService = pessoaService;
            _pessoaFisicaService = pessoaFisicaService;
        }

        public void ObterPessoas()
        {
            var lista = _pessoaFisicaService.GetAll();
        }
    }
}
