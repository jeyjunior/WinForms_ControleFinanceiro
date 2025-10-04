using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Atributos;

namespace CF.Domain.Entity
{
    [Entidade("TipoEntidadeFinanceira")]
    public class TipoEntidadeFinanceira
    {
        [ChavePrimaria]
        public int PK_TipoEntidadeFinanceira { get; set; }

        [Obrigatorio, TamanhoString(100)]
        public string Nome { get; set; }
    }
}
