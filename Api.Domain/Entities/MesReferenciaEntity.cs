using System.Collections.Generic;
using Api.Domain.Entities;

namespace Api.Domain.Entities
{
    public class MesReferenciaEntity : BaseEntity
    {
        public int Mes { get; set; }
        public int Ano { get; set; }

        public IEnumerable<TransacaoEntity> Transacoes { get; set; }
    }
}
