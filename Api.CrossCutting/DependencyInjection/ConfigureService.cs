
using Api.Domain.Interfaces.Services.MesReferencia;
using Api.Domain.Interfaces.Services.Entrada;
using Api.Domain.Interfaces.Services.PlanejamentoParcelado;
using Api.Domain.Interfaces.Services.Planejamentos;
using Api.Domain.Interfaces.Services.Poupanca;
using Api.Domain.Interfaces.Services.Saida;
using Api.Service.Services;

using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IMesReferenciaService, MesReferenciaService>();
            serviceCollection.AddTransient<IEntradaService, EntradaService>();
            serviceCollection.AddTransient<IPlanejamentoParceladoService, PlanejamentoParceladoService>();
            serviceCollection.AddTransient<IPlanejamentosService, PlanejamentosService>();
            serviceCollection.AddTransient<IPoupancaService, PoupancaService>();
            serviceCollection.AddTransient<ISaidaService, SaidaService>();

        }
    }
}
