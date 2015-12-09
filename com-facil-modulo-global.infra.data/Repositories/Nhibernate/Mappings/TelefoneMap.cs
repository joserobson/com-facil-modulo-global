using System;
using FluentNHibernate.Mapping;
using com_facil_modulo_global.domain.Entities;

namespace com_facil_modulo_global.infra.data.Repositories.Nhibernate.Mappings
{
    public class TelefoneMap: ClassMap<Telefone>
    {
        public TelefoneMap()
        {
            Table("tb_Telefone");
            Id(x => x.Id, "id_objeto")
                .Not.Nullable()
                .GeneratedBy.UuidHex("D");
            Map(x => x.Numero, "numero_telefone");
            Map(x => x.Tipo, "id_tipo_telefone");
        }
    }
}
