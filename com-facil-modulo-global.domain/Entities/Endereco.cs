using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Endereco:Entidade<string>
    {
        public virtual string Rua { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Cep { get; set; }
        public virtual string Referencia { get; set; }
        public virtual string Estado { get; set; }
    }
}
