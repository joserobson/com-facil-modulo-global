using com_facil_modulo_global.domain.Entities;
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

        public void ObterPessoaPorId()
        {
           var pessoa =  _pessoaFisicaService.Get(")Ý§ïr?ÜM?Üúû§");


        }


        public void InserirPessoaFisica()
        {
            var pessoa = new PessoaFisica();
            pessoa.Cpf = "06542045600";
            pessoa.DataNascimento = "05/10/1985";
            pessoa.Nome = "Lucas Vinicus de ASsis";
            pessoa.NomeMae = "Mariete das Dores Silva Assis";
            pessoa.Rg = "MG13177794";

            var telefone = new Telefone();
            telefone.Numero = "999934311";
            telefone.Tipo = Telefone.CELULAR;

            var telefones = new List<Telefone>();
            telefones.Add(telefone);
            pessoa.Telefones = telefones;

            var endereco = new Endereco();
            endereco.Bairro = "Centro";
            endereco.Cep = "36340000";
            endereco.Cidade = "Resende Costa";
            endereco.Complemento = "10";
            endereco.Estado = "MG";
            endereco.Numero = "5";
            endereco.Referencia = "";
            endereco.Rua = "Riua 7 de setebrmo";

            var enderecos = new List<Endereco>();
            enderecos.Add(endereco);
            pessoa.Enderecos = enderecos;

            _pessoaFisicaService.Insert(pessoa);            

        }
    }
}
