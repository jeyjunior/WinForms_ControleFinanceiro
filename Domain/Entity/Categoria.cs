using System;
using System.Collections.Generic;
using System.Text;
using Domain.Atributos;

namespace Domain.Entity
{
    [Entidade("Categoria")]
    public class Categoria
    {
        [ChavePrimaria]
        public int PK_Categoria { get; set; }

        [Obrigatorio]
        public string Nome { get; set; }

        [Obrigatorio, Relacionamento("Usuario", "PK_Usuario")]
        public int FK_Usuario { get; set; }
    }
}
