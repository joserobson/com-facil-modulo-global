using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Pessoa:Entidade<string>
    {        
        public string Nome { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }
        public IEnumerable<Telefone> Telefones { get; set; }
    }
}
