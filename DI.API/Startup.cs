using DI.API.Extension;
using DI.API.Mapping;
using DI.N_Classes_1_Interface;
using DI.Provider;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ClasseA>();
            services.AddScoped<ClasseB>();
            services.AddScoped<ClasseC>();
            // Uma Interface implementando muitas Classes
            services.AddTransient<Func<string, IUnicaInterface>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "A":
                        return serviceProvider.GetService<ClasseA>();
                    case "B":
                        return serviceProvider.GetService<ClasseB>();
                    case "C":
                        return serviceProvider.GetService<ClasseC>();
                    default:
                        return null;
                }

            });
            services.AddAutoMapper(typeof(PivotTeste));

            services.AddProvider();
            services.AddServicoProvedor();
            services.AddScoped<IServicoProvedor,Soma>();
            services.AddScoped<IScoped, Cenario>();
            services.AddTransient<ITransient, Cenario>();
            services.AddSingleton<ISingleton, Cenario>();
            services.AddSingleton<ISingletonInstance>(new Cenario(Guid.Empty));
            services.AddTransient<CenariosService>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DI.API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DI.API v1"));
            }

            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
