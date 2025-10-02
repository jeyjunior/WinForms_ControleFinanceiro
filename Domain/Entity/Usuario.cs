using System;
using System.Collections.Generic;
using System.Text;
using Domain.Atributos;

namespace Domain.Entity
{
    [Entidade("Usuario")]
    public class Usuario
    {
        [ChavePrimaria]
        public int PK_Usuario { get; set; }

        [Obrigatorio, TamanhoString(255)]
        public string Email { get; set; }

        [Obrigatorio, TamanhoString(255)]
        public string Login { get; set; }

        [TamanhoString(2000)]
        public string LoginApi { get; set; }
        [TamanhoString(255)]
        public string Senha { get; set; }
        [TamanhoString(255)]
        public string Salt { get; set; }

        [Obrigatorio]
        public DateTime DataCadastro { get; set; }
        [Obrigatorio]
        public bool Ativo { get; set; }
    }
}
