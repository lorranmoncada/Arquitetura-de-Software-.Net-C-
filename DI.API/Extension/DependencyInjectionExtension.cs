using DI.Provider;
using Microsoft.Extensions.DependencyInjection;
using PATTERNS.Adapter;
using PATTERNS.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.API.Extension
{
    public static class DependencyInjectionExtension
    {
        public static void AddProvider(this IServiceCollection service)
        {
            service.AddScoped<Dictionary<TesteEnum, Func<IServiceEstudo>>>(x =>
            {
                return new Dictionary<TesteEnum, Func<IServiceEstudo>>()
                {
                    [TesteEnum.Teste1] = () => new Teste1(),
                    [TesteEnum.Teste2] = () => new Teste2(),
                    [TesteEnum.Teste3] = () => new Teste3(),
                };
            });

        }

        public static void AddServicoProvedor(this IServiceCollection service)
        {
            service.AddScoped<Debitar>();
            service.AddScoped<AdapterDebitarMaster>();

            service.AddScoped<IDebitar, Debitar>();
            service.AddScoped<IDebitar, AdapterDebitarMaster>();
            service.AddScoped<IDebitarMaster, DebitarMaster>();
            service.AddSingleton(new Singleton());
            service.AddScoped(x => new ConfigProvider
            {
                ServicoProvedor = x.GetRequiredService<IServicoProvedor>()
            });

        }
    }
}
