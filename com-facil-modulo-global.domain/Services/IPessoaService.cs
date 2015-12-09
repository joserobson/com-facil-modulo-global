﻿using com_facil_modulo_global.domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com_facil_modulo_global.domain.Services
{
    public interface IPessoaService: IServiceBase<Pessoa>
    {
        List<Pessoa> ObterListaPessoa();
    }
}
