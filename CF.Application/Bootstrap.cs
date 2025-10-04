using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using CF.Domain.Interfaces;
using CF.InfraData;
using CF.InfraData.Repository;

namespace CF.Application
{
    public static class Bootstrap
    {
        public static void RegistrarRepositorios(IServiceCollection services)
        {
            BootstrapData.RegistrarServicos(services);

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
    }
}
