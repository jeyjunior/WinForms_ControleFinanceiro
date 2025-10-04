using CF.Application;
using CF.Domain.Interfaces.ViewModel;
using CF.ViewModel.ViewModel;
using CF.Domain.Interfaces;
using CF.InfraData;
using CF.InfraData.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace CF.ViewModel
{
    public static class Bootstrap
    {
        public static IServiceProvider ServiceProvider { get; set; }

        public static void Iniciar()
        {
            try
            {
                var host = Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) => 
                    {
                        CF.Application.Bootstrap.RegistrarRepositorios(services);
                        RegistrarViewModels(services);
                    })
                    .Build();

                ServiceProvider = host.Services;

                ConfiguracaoServicos.Iniciar();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro na inicialização: {ex}");
            }
        }
        private static void RegistrarViewModels(IServiceCollection services)
        {
            services.AddSingleton<ICategoriaVM, CategoriaVM>();
            services.AddSingleton<ITipoInvestimentoVM, TipoInvestimentoVM>();
        }
    }
}
