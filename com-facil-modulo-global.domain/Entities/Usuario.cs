using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Usuario: Entidade
    {
        public Pessoa Pessoa { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int NivelAcesso { get; set; }
        public int OrdemVisualizacao { get; set; }
        public int ativo { get; set; }
    }
}
