using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Atributos;

namespace CF.Domain.Entity
{
    [Entidade("TipoTransacao")]
    public class TipoTransacao
    {
        [ChavePrimaria]
        public int PK_TipoTransacao { get; set; }

        [Obrigatorio, TamanhoString(100)]
        public string Nome { get; set; }
    }
}
