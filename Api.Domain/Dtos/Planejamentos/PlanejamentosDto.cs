using System;
using Api.Domain.Entities;
namespace Api.Domain.Dtos.Planejamentos
{
    public class PlanejamentosDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Parcelas { get; set; }
        public string Descricao { get; set; }
    }
}
