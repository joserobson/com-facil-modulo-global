using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Pessoa:Entidade
    {        
        public virtual string Nome { get; set; }
        public virtual IEnumerable<Endereco> Enderecos { get; set; }
        public virtual IEnumerable<Telefone> Telefones { get; set; }
    }
}
