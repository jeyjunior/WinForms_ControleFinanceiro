using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Atributos;

namespace CF.Domain.Entity
{
    [Entidade("TipoInvestimento")]
    public class TipoInvestimento
    {
        [ChavePrimaria]
        public int PK_TipoInvestimento { get; set; }
        [Obrigatorio, TamanhoString(100)]
        public string Nome { get; set; }
    }
}
