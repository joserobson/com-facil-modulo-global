using com_facil_modulo_global.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace com_facil_modulo_global.infra.data.Repositories.Nhibernate.Mappings
{
    public class PessoaFisicaMap: SubclassMap<PessoaFisica>
    {
        public PessoaFisicaMap()
        {
            DiscriminatorValue(@"1");
            Map(x => x.DataNascimento, "data_Nascimento_Pessoa");
            Map(x => x.Cpf, "cpf_Pessoa");
            Map(x => x.Rg, "rg_Pessoa");
            Map(x => x.NomeMae, "nome_mae_Pessoa");
        }
    }
}
