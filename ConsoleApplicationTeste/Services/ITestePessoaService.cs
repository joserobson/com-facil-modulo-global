using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTeste.Services
{
    public interface ITestePessoaService
    {
        void ObterPessoas();

        void InserirPessoaFisica();

        void ObterPessoaPorId();
    }
}
