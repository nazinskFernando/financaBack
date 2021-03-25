using Api.Domain.Entities;
using System;
namespace Api.Domain.Entities
{
    public class PlanejamentoParceladoEntity : BaseEntity
    {
        public double Valor { get; set; }
        public int ParcelaTotal { get; set; }
        public int ParcelaAtual { get; set; }

        public Guid MesReferenciaId { get; set; }
        public Guid PlanejamentoId { get; set; }

        public PlanejamentosEntity Planejamentos { get; set; }
        public MesReferenciaEntity MesReferencia { get; set; }
    }
}
