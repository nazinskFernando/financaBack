namespace Api.Domain.Entities
{
    public class TransacaoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public int Parcelas { get; set; }
        public bool IsPago { get; set; }
        public bool IsFixa { get; set; }
    }
}
