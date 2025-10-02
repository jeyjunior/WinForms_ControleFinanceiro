using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Domain.Interfaces;
using InfraData;
using InfraData.Repository;

namespace CF.Application
{
    public static class Bootstrap
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void Iniciar()
        {
            try
            {
                var host = Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) => RegistrarServicos(services))
                    .Build();

                ServiceProvider = host.Services;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro na inicialização: {ex}");
            }
        }

        private static void RegistrarServicos(IServiceCollection services)
        {
            BootstrapData.RegistrarServicos(services);

            RegistrarRepositorios(services);
            RegistrarViewModels(services);
        }

        private static void RegistrarRepositorios(IServiceCollection services)
        {
            services.AddSingleton<IUsuarioRepository, UsuarioRepository>();
            services.AddSingleton<ITipoEntidadeFinanceiraRepository, TipoEntidadeFinanceiraRepository>();
            services.AddSingleton<ICategoriaRepository, CategoriaRepository>();
            services.AddSingleton<ITipoTransacaoRepository, TipoTransacaoRepository>();
            services.AddSingleton<ITipoInvestimentoRepository, TipoInvestimentoRepository>();
            services.AddSingleton<IAtivoFinanceiroRepository, AtivoFinanceiroRepository>();
            services.AddSingleton<IEntidadeFinanceiraRepository, EntidadeFinanceiraRepository>();
            services.AddSingleton<ITransacaoRepository, TransacaoRepository>();
            services.AddSingleton<IDetalheInvestimentoRepository, DetalheInvestimentoRepository>();
            services.AddSingleton<IProventoRepository, ProventoRepository>();
        }

        private static void RegistrarViewModels(IServiceCollection services)
        {
        }
    }
}
