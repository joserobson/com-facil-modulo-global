
namespace com_facil_modulo_global.domain.Entities
{
    public class Funcionario: Entidade
    {
        public Pessoa Pessoa { get; set; }
        public int TipoContrato { get; set; }
        public string CodigoFuncionario { get; set; }
        public string DataFuncionario { get; set; }
        public Usuario Usuario { get; set; }
        public int Ativo { get; set; }
    }
}
