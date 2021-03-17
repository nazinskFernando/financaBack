namespace Api.Domain.Entities
{
    public enum TipoOperacaoEntrada
    {
        SALARIO,
        EXTRA,
        OUTROS
    }
    public class EntradaEntity : TransacaoEntity
    {
        public TipoOperacaoEntrada TipoOperacaoEntrada { get; set; }
    }
}
