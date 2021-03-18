using System;
using Api.Domain.Entities;
using Api.Domain.Dtos.MesReferencia;
namespace Api.Domain.Dtos.Transacao
{
    public class TransacaoDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Parcelas { get; set; }
        public bool IsPago { get; set; }
        public bool IsFixa { get; set; }

        public TipoOperacaoEntrada TipoOperacaoEntrada { get; set; } 
        public TipoOperacaoSaida TipoOperacaoSaida { get; set; } 
        public TipoOperacao TipoOperacao { get; set; } 
        public MesReferenciaDto MesReferencia { get; set; }
    }
}
