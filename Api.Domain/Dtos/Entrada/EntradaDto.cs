using System;
using Api.Domain.Entities;
namespace Api.Domain.Dtos.Entrada
{
    public class EntradaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Parcelas { get; set; }
        public bool IsPago { get; set; }
        public bool IsFixa { get; set; }
        public Guid IsFixId { get; set; }
        public Guid MesReferenciaId { get; set; }
        public Guid? PoupancaId { get; set; }

        public TipoOperacaoEntrada TipoOperacaoEntrada { get; set; }
    }
}
