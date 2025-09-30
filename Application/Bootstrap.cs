using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Domain.Interfaces;
using InfraData;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Application
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
            //services.AddSingleton<ITipoTransacaoRepository, TipoTransacaoRepository>();
        }

        private static void RegistrarViewModels(IServiceCollection services)
        {
            //services.AddSingleton<IMainWindowViewModel, MainWindowViewModel>();
        }
    }
}
