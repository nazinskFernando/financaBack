using Api.Domain.Entities;
using System;
namespace Api.Domain.Entities
{
    public enum TipoOperacaoSaida
    {
        INVALIDO,
        PORCENTAGEM,
        COMUM
    }
    public class SaidaEntity : BaseEntity
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Parcelas { get; set; }
        public bool IsPago { get; set; }
        public bool IsFixa { get; set; } 
        public Guid? IsFixId { get; set; }
        public Guid? MesReferenciaId { get; set; }
        public Guid? PoupancaId { get; set; }

        public virtual MesReferenciaEntity MesReferencia { get; set; } 
        public virtual PoupancaEntity Poupanca { get; set; } 
        public TipoOperacaoSaida TipoOperacaoSaida { get; set; }
    }
}
