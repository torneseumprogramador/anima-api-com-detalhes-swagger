using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Vitor.Bandeira.Context;
using Vitor.Bandeira.Repository;

namespace Vitor.Bandeira.Extensions
{
    public static class BuilderExtensions
    {
        public static WebApplicationBuilder AddDataBase(this WebApplicationBuilder builder)
        {
            var cnn = builder.Configuration.GetConnectionString("cnn");
            builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(cnn, ServerVersion.AutoDetect(cnn)));
            return builder;
        }
        public static WebApplicationBuilder AddSwaggerGen(this WebApplicationBuilder builder)
        {
            builder.Services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "API v1 de Veiculo Simples",
                    Version = "1.0",
                    Description = "API para gerenciar os veiculos",
                    Contact = new OpenApiContact
                    {
                        Name = "Turma Ânima",
                        Email = "vitor.bandeira@animaeducacao.com.br",
                        Url = new Uri("https://www.gama.academy.com.br")
                    }
                });
                options.SwaggerDoc("v2", new OpenApiInfo
                {
                    Title = "API v2 de Veiculo Simples",
                    Version = "2.0",
                    Description = "Api para gerenciar veiculos",
                    Contact = new OpenApiContact
                    {
                        Name = "Turma Anima Nova",
                        Email = "turma.anima@animaeducacao.com.br",
                        Url = new Uri("https://www.google.com.br")
                    }
                });
            });
            return builder;
        }
        public static WebApplicationBuilder AddReferenceRepository(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IVeiculoRepository, RepositoryVeiculo>();

            return builder;
        }
    }
}