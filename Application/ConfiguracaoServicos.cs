using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class ConfiguracaoServicos
    {
        public static void Iniciar()
        {
            RegistrarEntidades();
        }
        public static void RegistrarEntidades()
        {
            var uow = Bootstrap.ServiceProvider.GetRequiredService<IUnitOfWork>();
            //uow.Connection.CriarTabela(typeof(Usuario));
            //uow.Connection.CriarTabela(typeof(TipoEntidadeFinanceira));
            //uow.Connection.CriarTabela(typeof(Categoria));
            //uow.Connection.CriarTabela(typeof(EntidadeFinanceira));
            //uow.Connection.CriarTabela(typeof(TipoTransacao));
            //uow.Connection.CriarTabela(typeof(Transacao));
            //uow.Connection.CriarTabela(typeof(TipoInvestimento));
            //uow.Connection.CriarTabela(typeof(AtivoFinanceiro));
            //uow.Connection.CriarTabela(typeof(DetalheInvestimento));
            //uow.Connection.CriarTabela(typeof(Provento));
        }
    }
}
