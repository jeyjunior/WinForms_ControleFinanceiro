using CF.Data;
using CF.Data.Extensao;
using CF.Domain.Atributos;
using CF.Domain.Entity;
using CF.Domain.Interfaces;
using CF.InfraData.Repository;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CF.Application
{
    public static class ConfiguracaoServicos
    {
        public static void Iniciar()
        {
            RegistrarEntidades();
        }
        public static void RegistrarEntidades()
        {
            try
            {
                using (var uow = new UnitOfWork())
                {
                    if (!uow.Connection.VerificarTabelaExistente<Usuario>())
                        uow.Connection.CriarTabela(typeof(Usuario));

                    if (!uow.Connection.VerificarTabelaExistente<TipoTransacao>())
                        uow.Connection.CriarTabela(typeof(TipoTransacao));

                    if (!uow.Connection.VerificarTabelaExistente<TipoInvestimento>())
                        uow.Connection.CriarTabela(typeof(TipoInvestimento));

                    if (!uow.Connection.VerificarTabelaExistente<TipoEntidadeFinanceira>())
                        uow.Connection.CriarTabela(typeof(TipoEntidadeFinanceira));

                    if (!uow.Connection.VerificarTabelaExistente<Categoria>())
                        uow.Connection.CriarTabela(typeof(Categoria));

                    if (!uow.Connection.VerificarTabelaExistente<AtivoFinanceiro>())
                        uow.Connection.CriarTabela(typeof(AtivoFinanceiro));

                    if (!uow.Connection.VerificarTabelaExistente<EntidadeFinanceira>())
                        uow.Connection.CriarTabela(typeof(EntidadeFinanceira));

                    if (!uow.Connection.VerificarTabelaExistente<Transacao>())
                        uow.Connection.CriarTabela(typeof(Transacao));

                    if (!uow.Connection.VerificarTabelaExistente<DetalheInvestimento>())
                        uow.Connection.CriarTabela(typeof(DetalheInvestimento));

                    if (!uow.Connection.VerificarTabelaExistente<Provento>())
                        uow.Connection.CriarTabela(typeof(Provento));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao tentar gerar tabelas na base de dados.");
            }
        }

        private static IEnumerable<Type> ObterEntidadesMapeadas()
        {
            var assemblies = AppDomain.CurrentDomain.GetAssemblies().ToList();

            if (!assemblies.Any(a => a.FullName.Contains("Domain")))
            {
                var domainAssembly = Assembly.Load("Domain");
                assemblies.Add(domainAssembly);
            }

            return assemblies
                .SelectMany(a => a.GetTypes())
                .Where(t => t.GetCustomAttribute<EntidadeAttribute>() != null && t.IsClass && !t.IsAbstract);
        }
    }
}
