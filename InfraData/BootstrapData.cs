using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace InfraData
{
    public static class BootstrapData
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
        }
    }
}
