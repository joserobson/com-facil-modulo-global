using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class PessoaJuridica:Pessoa
    {
        public virtual string Cnpj { get; set; }
        public virtual string IE { get; set; }
    }
}
