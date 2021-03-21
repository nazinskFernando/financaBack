using System;
using Api.Domain.Entities;
namespace Api.Domain.Entities
{
    public enum TipoOperacaoEntrada
    {
        INVALIDO,
        SALARIO,
        EXTRA,
        OUTROS
    }
    public enum TipoOperacaoSaida
    {
        INVALIDO,
        PORCENTAGEM,
        COMUM
    }
    public enum TipoOperacao{
        ENTRADA,
        SAIDA
    }
    public class TransacaoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Parcelas { get; set; }
        public bool IsPago { get; set; }
        public bool IsFixa { get; set; } 
        public Guid IsFixId { get; set; }
        public Guid MesReferenciaId { get; set; }

        public virtual MesReferenciaEntity MesReferencia { get; set; } 

        public TipoOperacaoEntrada TipoOperacaoEntrada { get; set; } 
        public TipoOperacaoSaida TipoOperacaoSaida { get; set; } 
        public TipoOperacao TipoOperacao { get; set; } 
     }
}
