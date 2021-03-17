using System.Collections.Generic;
using Api.Domain.Dtos.Entrada;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.Entrada
{
    public interface IEntradaService
    {
        Task<EntradaDto> Get(Guid id);
        Task<IEnumerable<EntradaDto>> GetAll();
        Task<EntradaDto> Post(EntradaDto termo);
        Task<EntradaDto> Put(EntradaDto termo);
        Task<bool> Delete(Guid id);
    }
}
