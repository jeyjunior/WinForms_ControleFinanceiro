using System;
using System.Collections.Generic;
using System.Text;
using Domain.Atributos;

namespace Domain.Entity
{
    [Entidade("DetalheInvestimento")]
    public class DetalheInvestimento
    {
        [ChavePrimaria]
        public long PK_DetalheInvestimento { get; set; }
        
        [Obrigatorio, Relacionamento("Transacao", "PK_Transacao")]
        public int FK_Transacao { get; set; }
        [Obrigatorio, Relacionamento("AtivoFinanceiro", "PK_AtivoFinanceiro")]
        public int FK_AtivoFinanceiro { get; set; }

        [Obrigatorio, TamanhoDecimal(18,2)]
        public decimal QuantidadeCotas { get; set; }
        [Obrigatorio, TamanhoDecimal(18, 2)]
        public decimal ValorUnitario { get; set; }
        [TamanhoDecimal(18, 2)]
        public decimal Imposto { get; set; }
        [TamanhoDecimal(18, 2)]
        public decimal OutrosCustos { get; set; }
    }
}
