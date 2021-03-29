using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class MesReferenciaImplementation : BaseRepository<MesReferenciaEntity>, IMesReferenciaRepository
    {
        private DbSet<MesReferenciaEntity> _dataset;

        public MesReferenciaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<MesReferenciaEntity>();
        }

       public async Task<MesReferenciaEntity> fintByMesAno(int mes, int ano){

           return await _dataset.FirstOrDefaultAsync(mr => mr.Mes.Equals(mes) && mr.Ano.Equals(ano));
       }

       public async Task<IEnumerable<MesReferenciaEntity>> GetMesesAFrente(int mes, int ano){
           IQueryable<MesReferenciaEntity> query = _dataset;

            query = query.AsNoTracking()
                        .Where(mr => mr.Mes > mes && mr.Ano >= ano);

            return await query.ToArrayAsync();
       }

    }
}
