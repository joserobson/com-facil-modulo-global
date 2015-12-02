using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public class PessoaService:IPessoaService
    {
        private readonly IPessoaRepositorio _pessoaRepository;

        public PessoaService(IPessoaRepositorio pessoaRepository)
        {
            this._pessoaRepository = pessoaRepository;
        }

        [UnitOfWork]
        public List<Pessoa> ObterListaPessoa()
        {
            return _pessoaRepository.GetAll().ToList();
        }
    }
}
