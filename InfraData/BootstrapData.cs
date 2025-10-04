using System;
using System.Collections.Generic;
using System.Text;
using CF.Data;
using CF.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CF.InfraData
{
    public static class BootstrapData
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
        }
    }
}
