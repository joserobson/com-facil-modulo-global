using com_facil_modulo_global.domain.Entities;
using FluentNHibernate.Mapping;

namespace com_facil_modulo_global.infra.data.Repositories.Nhibernate.Mappings
{
    public class PessoaMap: ClassMap<Pessoa>
    {
        public PessoaMap()
        {
            Table("tb_Pessoa");            
            Id(x => x.Id,"id_objeto")
                .Not.Nullable();
            DiscriminateSubClassesOnColumn("id_tipo_Pessoa").Not.Nullable();
            Map(x => x.Nome,"nome_Pessoa");
            HasManyToMany(x => x.Telefones).Table("tb_Pessoa_Telefone")
                .ParentKeyColumn("id_Pessoa")
                .ChildKeyColumn("id_Telefone")
                .Not.LazyLoad();
        }
    }
}
