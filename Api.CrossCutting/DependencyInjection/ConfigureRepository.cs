using System;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Data.Repository;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {

        public static void ConfigureDependenciesRepository(IServiceCollection serviceCollection, string conexao)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));

            serviceCollection.AddScoped<IProdutoRepository, ProdutoImplementation>();
            serviceCollection.AddScoped<IEntradaRepository, EntradaImplementation>();
            serviceCollection.AddScoped<ISaidaRepository, SaidaImplementation>();
            serviceCollection.AddScoped<IMesReferenciaRepository, MesReferenciaImplementation>();
            serviceCollection.AddScoped<ITransacaoRepository, TransacaoImplementation>();

            serviceCollection.AddDbContext<MyContext>(
                options => options.UseMySql(conexao)
            );

        }
    }
}
