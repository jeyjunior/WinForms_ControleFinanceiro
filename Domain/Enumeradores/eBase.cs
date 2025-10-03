using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Enumeradores
{
    public enum eTipoBancoDados
    {
        SQLite = 1,
        SQLServer = 2,
        MySQL = 3,
    }

    public enum eTipoOperacao
    {
        Visualizar = 1,
        Adicionar = 2,
        Editar = 3,
        Excluir = 4,
        Salvar =5,
        Cancelar = 6
    }
}
