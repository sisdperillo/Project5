using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace DevProject.API.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "DevProject.API",
                    Version = "v1",
                    Description = "Aplicação criada em .NET 5 para fins de estudo" ,
                    Contact = new OpenApiContact
                    {
                        Name = "Diego Perillo", 
                        Email = string.Empty
                    }
                });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerUi(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevProject.API v1"));

            return app;
        }
    }
}
