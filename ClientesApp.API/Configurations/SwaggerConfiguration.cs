using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace ClientesApp.API.Configurations
{
    /// <summary>
    /// Classe para configuração da biblioteca do Swagger
    /// </summary>
    public class SwaggerConfiguration
    {
        /// <summary>
        /// Método para definir as configurações / preferências do Swagger
        /// </summary>
        public static void AddSwaggerConfiguration(IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                //Definindo informações da API
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "ClientesApp - API para controle de clientes",
                    Description = "API desenvolvida pela COTI Informática (www.cotiinformatica.com.br) para gerenciamento de clientes.",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "COTI Informática",
                        Email = "contato@cotiinformatica.com.br",
                        Url = new Uri("https://www.cotiinformatica.com.br")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }

                });
            });
        }

        /// <summary>
        /// Método para executar e aplicar as configurações do Swagger
        /// </summary>
        public static void UseSwaggerConfiguration(IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
    }
}
