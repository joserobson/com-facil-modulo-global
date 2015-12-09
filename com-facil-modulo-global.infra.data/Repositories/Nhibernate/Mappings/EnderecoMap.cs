using com_facil_modulo_global.domain.Entities;
using FluentNHibernate.Mapping;
using System;

namespace com_facil_modulo_global.infra.data.Repositories.Nhibernate.Mappings
{
    public class EnderecoMap: ClassMap<Endereco>
    {
        public EnderecoMap()
        {
            Table("tb_Endereco");
            Id(x => x.Id, "id_objeto")
                .Not.Nullable()
                .GeneratedBy.UuidHex("D");
            Map(x => x.Bairro, "bairro_endereco");
            Map(x => x.Cep, "cep_endereco");
            Map(x => x.Cidade, "cidade_endereco");
            Map(x => x.Complemento, "complemento_endereco");
            Map(x => x.Estado, "estado_endereco");
            Map(x => x.Numero, "numero_endereco");
            Map(x => x.Referencia, "referencia_endereco");
            Map(x => x.Rua, "rua_endereco");            
        }
    }
}
