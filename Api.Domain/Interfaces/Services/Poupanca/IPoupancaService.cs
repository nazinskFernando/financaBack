using System.Collections.Generic;
using Api.Domain.Dtos.Poupanca;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.Poupanca
{
    public interface IPoupancaService
    {
        Task<PoupancaDto> Get(Guid id);
        Task<IEnumerable<PoupancaDto>> GetAll();
        Task<PoupancaDto> Post(PoupancaDto termo);
        Task<PoupancaDto> Put(PoupancaDto termo);
        Task<bool> Delete(Guid id);
    }
}
