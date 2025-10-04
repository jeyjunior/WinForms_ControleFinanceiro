using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Atributos;

namespace CF.Domain.Entity
{
    [Entidade("Transacao")]
    public class Transacao
    {
        [ChavePrimaria]
        public long PK_Transacao { get; set; }

        [Obrigatorio, Relacionamento("TipoTransacao", "PK_TipoTransacao")]
        public int FK_TipoTransacao { get; set; }

        [Obrigatorio, Relacionamento("EntidadeFinanceira", "PK_EntidadeFinanceira")]
        public long FK_EntidadeFinanceira { get; set; }

        [Obrigatorio, TamanhoDecimal(18,2)]
        public decimal Valor { get; set; }
        [Obrigatorio]
        public DateTime DataTransacao { get; set; }
        public DateTime? DataVencimento { get; set; }
        [TamanhoString(300)]
        public string Observacao { get; set; }
        [Relacionamento("Usuario", "PK_Usuario")]
        public int? FK_Usuario { get; set; }
    }
}
