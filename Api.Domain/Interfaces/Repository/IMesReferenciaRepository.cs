using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IMesReferenciaRepository : IRepository<MesReferenciaEntity>
    {
        Task<MesReferenciaEntity> fintByMesAno(int mes, int ano);
    }
}
