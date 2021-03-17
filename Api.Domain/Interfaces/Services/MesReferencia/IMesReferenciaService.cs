using System.Collections.Generic;
using Api.Domain.Dtos.MesReferencia;
using System.Threading.Tasks;
using System;

namespace Api.Domain.Interfaces.Services.MesReferencia
{
    public interface IMesReferenciaService
    {
        Task<MesReferenciaDto> Get(Guid id);
        Task<IEnumerable<MesReferenciaDto>> GetAll();
        Task<MesReferenciaDto> Post(MesReferenciaDto termo);
        Task<MesReferenciaDto> Put(MesReferenciaDto termo);
        Task<bool> Delete(Guid id);
    }
}
