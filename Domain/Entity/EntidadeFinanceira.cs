using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Atributos;

namespace CF.Domain.Entity
{
    [Entidade("EntidadeFinanceira")]
    public class EntidadeFinanceira
    {
        [ChavePrimaria]
        public long PK_EntidadeFinanceira { get; set; }

        [Obrigatorio]
        public int FK_TipoEntidadeFinanceira { get; set; }

        [Obrigatorio, Relacionamento("Categoria", "PK_Categoria")]
        public int FK_Categoria { get; set; }

        [Obrigatorio, TamanhoString(100)]
        public string Nome { get; set; }
        [Obrigatorio]
        public DateTime DataCadastro { get; set; }
        [Obrigatorio]
        public bool Ativo { get; set; }
        [Relacionamento("Usuario", "PK_Usuario")]
        public int? FK_Usuario { get; set; }
    }
}
