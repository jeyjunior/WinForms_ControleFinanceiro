using System;
using System.Collections.Generic;
using System.Text;

namespace CF.Domain.Dto
{
    public class EntidadeValidacao
    {
        public Type TipoEntidade { get; set; }
        public string Nome => TipoEntidade?.Name;
        public bool Existe { get; set; }
    }
}
