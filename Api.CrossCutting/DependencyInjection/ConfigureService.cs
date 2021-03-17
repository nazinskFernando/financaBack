
using Api.Domain.Interfaces.Services.Produto;
using Api.Domain.Interfaces.Services.Entrada;
using Api.Domain.Interfaces.Services.Saida;
using Api.Domain.Interfaces.Services.MesReferencia;
using Api.Domain.Interfaces.Services.Transacao;
using Api.Service.Services;

using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IProdutoService, ProdutoService>();
            serviceCollection.AddTransient<IEntradaService, EntradaService>();
            serviceCollection.AddTransient<ISaidaService, SaidaService>();
            serviceCollection.AddTransient<IMesReferenciaService, MesReferenciaService>();
            serviceCollection.AddTransient<ITransacaoService, TransacaoService>();

        }
    }
}
