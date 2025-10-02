using Data;
using Data.Extensao;
using Domain.Atributos;
using Domain.Entity;
using Domain.Interfaces;
using InfraData.Repository;
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
                    var entidades = ObterEntidadesMapeadas();
                    var tabelasExistentes = uow.Connection.VerificarEntidadeExiste(entidades);

                    if (tabelasExistentes.Any(i => !i.Existe))
                    {
                        try
                        {
                            uow.Begin();

                            foreach (var entidade in tabelasExistentes.Where(e => !e.Existe))
                                uow.Connection.CriarTabela(entidade.TipoEntidade, uow.Transaction);

                            uow.Commit();
                        }
                        catch (SqlException ex)
                        {
                            uow.Rollback();
                            throw new Exception("Erro ao criar as entidades no banco de dados", ex);
                        }
                        catch (Exception ex)
                        {
                            uow.Rollback();
                            throw new Exception("Erro inesperado ao criar as entidades", ex);
                        }
                    }
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
