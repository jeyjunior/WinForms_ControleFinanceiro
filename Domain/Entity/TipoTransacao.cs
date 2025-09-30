using Domain.Atributos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entity
{
    [Entidade("TipoTransacao")]
    public class TipoTransacao
    {
        [ChavePrimaria]
        public int PK_TipoTransacao { get; set; }

        [Obrigatorio]
        public string Nome { get; set; }
    }
}
