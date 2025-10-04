using System;
using System.Collections.Generic;
using System.Text;
using CF.Domain.Enumeradores;

namespace CF.Domain.Dto
{
    public class ParametrosConfiguracao
    {
        public bool Ativo { get; set; } 
        public eTipoBancoDados TipoBanco { get; set; }
        public string StringConexao { get; set; }
        public string NomeAplicacao { get; set; } = string.Empty;
    }
}
