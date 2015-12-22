
namespace com_facil_modulo_global.domain.Entities
{
    public class Fornecedor:Entidade
    {
        public virtual Pessoa Pessoa { get; set; }
        public virtual string Observacao { get; set; }
        public virtual string representante { get; set; }
        public virtual string email { get; set; }
        public virtual string site { get; set; }
    }
}
