using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Entidade<TPrimaryKey> : IEntidade<TPrimaryKey>
    {
        public virtual TPrimaryKey Id { get; set; }
    }
}
