using System.Collections.Generic;
using Api.Domain.Dtos.Planejamentos;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.Planejamentos
{
    public interface IPlanejamentosService
    {
        Task<PlanejamentosDto> Get(Guid id);
        Task<IEnumerable<PlanejamentosDto>> GetAll();
        Task<PlanejamentosDto> Post(PlanejamentosDto termo);
        Task<PlanejamentosDto> Put(PlanejamentosDto termo);
        Task<bool> Delete(Guid id);
    }
}
