using com_facil_modulo_global.domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Telefone:Entidade<string>
    {
        public string Numero { get; set; }
        public ETipoTelefone Tipo { get; set; }

    }
}
