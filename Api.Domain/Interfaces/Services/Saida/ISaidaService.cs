using System.Collections.Generic;
using Api.Domain.Dtos.Saida;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.Saida
{
    public interface ISaidaService
    {
        Task<SaidaDto> Get(Guid id);
        Task<IEnumerable<SaidaDto>> GetAll();
        Task<SaidaDto> Post(SaidaDto termo);
        Task<SaidaDto> Put(SaidaDto termo);
        Task<bool> Delete(Guid id);
    }
}
