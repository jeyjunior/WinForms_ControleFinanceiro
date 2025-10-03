using System;
using System.Collections.Generic;
using System.Text;
using Domain.Atributos;

namespace Domain.Entity
{
    [Entidade("Provento")]
    public class Provento
    {
        [ChavePrimaria]
        public long PK_Provento { get; set; }
        [Obrigatorio, Relacionamento("Transacao", "PK_Transacao")]
        public long FK_Transacao { get; set; }
        [Obrigatorio, Relacionamento("AtivoFinanceiro", "PK_AtivoFinanceiro")]
        public long FK_AtivoFinanceiro { get; set; }
        [TamanhoDecimal(18, 2)]
        public decimal QuantidadeCotas { get; set; }
        [TamanhoDecimal(18, 2)]
        public decimal ValorPorCota { get; set; }
        [TamanhoDecimal(18, 2)]
        public decimal Imposto { get; set; }
        [TamanhoString(255)]
        public string Descricao { get; set; }
    }
}
