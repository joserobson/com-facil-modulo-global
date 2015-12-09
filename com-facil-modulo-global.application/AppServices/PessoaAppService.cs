using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.application.AppServices
{
    public class PessoaAppService: IPessoaAppService
    {
        private readonly IPessoaFisicaService _pessoaFisicaService;

        public PessoaAppService(IPessoaFisicaService pessoaFisicaService)
        {
            _pessoaFisicaService = pessoaFisicaService;
        }

        public IEnumerable<Pessoa> ObterPessoas()
        {
            return _pessoaFisicaService.GetAll();
        }
    }
}
