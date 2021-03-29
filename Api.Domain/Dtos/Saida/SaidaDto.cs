using System;
using Api.Domain.Entities;
namespace Api.Domain.Dtos.Saida
{
    public class SaidaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public double? Porcentagem { get; set; }
        public string Descricao { get; set; }
        public string Parcelas { get; set; }
        public bool IsPago { get; set; }
        public bool IsFixa { get; set; }
        public Guid IsFixId { get; set; }
        public Guid MesReferenciaId { get; set; }
        public Guid? PoupancaId { get; set; }
        public Guid? EntradaId { get; set; }

        public TipoOperacaoSaida TipoOperacaoSaida { get; set; }
    }
}
