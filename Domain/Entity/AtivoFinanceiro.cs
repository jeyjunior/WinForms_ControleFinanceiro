using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Atributos;

namespace CF.Domain.Entity
{
    [Entidade("AtivoFinanceiro")]
    public class AtivoFinanceiro
    {
        [ChavePrimaria]
        public long PK_AtivoFinanceiro { get; set; }
        [Obrigatorio, TamanhoString(50)]
        public string Codigo { get; set; }
        [TamanhoString(255)]
        public string Nome { get; set; }

        [Obrigatorio, Relacionamento("TipoInvestimento", "PK_TipoInvestimento")]
        public int FK_TipoInvestimento { get; set; }
        [Obrigatorio]
        public bool Ativo { get; set; }
        [Relacionamento("Usuario", "PK_Usuario")]
        public int? FK_Usuario { get; set; }
    }
}
