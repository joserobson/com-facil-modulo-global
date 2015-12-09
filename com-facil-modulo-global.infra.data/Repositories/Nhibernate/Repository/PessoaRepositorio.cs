using com_facil_modulo_global.domain.Entities;
using com_facil_modulo_global.domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.infra.data.Repositories.Nhibernate.Repository
{
    public class PessoaRepositorio: RepositorioBase<Pessoa>, IPessoaRepositorio
    {
    }
}
