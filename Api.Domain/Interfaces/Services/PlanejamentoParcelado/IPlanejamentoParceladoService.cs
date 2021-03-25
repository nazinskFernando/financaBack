using System.Collections.Generic;
using Api.Domain.Dtos.PlanejamentoParcelado;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.PlanejamentoParcelado
{
    public interface IPlanejamentoParceladoService
    {
        Task<PlanejamentoParceladoDto> Get(Guid id);
        Task<IEnumerable<PlanejamentoParceladoDto>> GetAll();
        Task<PlanejamentoParceladoDto> Post(PlanejamentoParceladoDto termo);
        Task<PlanejamentoParceladoDto> Put(PlanejamentoParceladoDto termo);
        Task<bool> Delete(Guid id);
    }
}
