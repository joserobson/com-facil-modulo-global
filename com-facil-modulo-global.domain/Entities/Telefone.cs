using com_facil_modulo_global.domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Telefone:Entidade
    {
        public const string CELULAR = "1";
        public const string RESIDENCIAL = "2";
        public const string COMERCIAL = "3";


        public virtual string Numero { get; set; }
        public virtual string Tipo { get; set; }

    }
}
