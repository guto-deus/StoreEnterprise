using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace SE.Identidade.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(name: "v1", new OpenApiInfo
                {
                    Title = "Store Enterprise Identity API",
                    Description = "Esta API faz parte do projeto Store Enterprise",
                    Contact = new OpenApiContact() { Name = "Agostinho Lucas Deus", Email = "agostinholucasdeus@gmail.com" },
                    License = new OpenApiLicense() { Name = "LINKEDIN", Url = new Uri("https://linkedin.com/in/agostinho-lucas-deus") }
                });
            });

            return services;
        }

        public static IApplicationBuilder USeSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Store.Enterprise.Api v1"));
            });

            return app;
        }
    }
}