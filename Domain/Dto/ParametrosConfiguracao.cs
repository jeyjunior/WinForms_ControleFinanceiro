using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enumeradores;

namespace Domain.Dto
{
    public class ParametrosConfiguracao
    {
        public bool Ativo { get; set; } 
        public TipoBancoDados TipoBanco { get; set; }
        public string StringConexao { get; set; }
        public string NomeAplicacao { get; set; } = string.Empty;
    }
}
