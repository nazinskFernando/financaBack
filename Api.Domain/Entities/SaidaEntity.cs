namespace Api.Domain.Entities
{
    public enum TipoOperacaoSaida
    {
        PORCENTAGEM,
        COMUM
    }
    public class SaidaEntity : TransacaoEntity
    {
        public TipoOperacaoSaida TipoOperacaoSaida { get; set; }
    }
}
