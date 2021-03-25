
using Api.Domain.Entities;
using System;
using System.Collections.Generic;
namespace Api.Domain.Entities
{
    public class PlanejamentosEntity : BaseEntity
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Parcelas { get; set; }
        public string Descricao { get; set; }

        public IEnumerable<PlanejamentoParceladoEntity> PlanejamentoParcelados { get; set; }
    }
}
