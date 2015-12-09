using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public class PessoaFisicaService : ServiceBase<PessoaFisica>, IPessoaFisicaService
    {
        private readonly IPessoaFisicaRepositorio _pessoaRepository;

        public PessoaFisicaService(IPessoaFisicaRepositorio pessoaRepository)
            : base(pessoaRepository)
        {
            this._pessoaRepository = pessoaRepository;
        }
    }
}
