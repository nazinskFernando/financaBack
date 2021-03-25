using System;
using Api.Domain.Entities;
namespace Api.Domain.Dtos.PlanejamentoParcelado
{
    public class PlanejamentoParceladoDto
    {
        public Guid Id { get; set; }
        public double Valor { get; set; }
        public int ParcelaTotal { get; set; }
        public int ParcelaAtual { get; set; }

        public Guid MesReferenciaId { get; set; }
        public Guid PlanejamentoId { get; set; }

        public PlanejamentosEntity Planejamentos { get; set; }
        public MesReferenciaEntity MesReferencia { get; set; }
    }
}
