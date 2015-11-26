using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class PessoaFisica: Pessoa
    {
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string NomeMae { get; set; }
    }
}
