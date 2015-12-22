using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Entities
{
    public class Cliente : Entidade
    {
        public virtual Pessoa pessoa { get; set; }
        public virtual string DataCadastro { get; set; }
        public virtual string CodigoFicha { get; set; }
        public virtual string CodigoCliente { get; set; }
        public virtual int SituacaoCliente { get; set; }
        public virtual string SituacaoAtividadeCliente { get; set; }
        public virtual string NumerosFichas { get; set; }
        public virtual string Email { get; set; }
        public virtual string AutorizacaoPara { get; set; }
        public virtual string Observacao { get; set; }
        public virtual string LimiteCredito { get; set; }
        public virtual string SituacaoCobranca { get; set; }


    }
}
