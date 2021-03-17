using System.Collections.Generic;
using Api.Domain.Entities;
using System;

namespace Api.Domain.Dtos.MesReferencia
{
    public class MesReferenciaDto
    {
        public Guid Id { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }

        public IEnumerable<TransacaoEntity> Transacoes { get; set; }
    }
}
