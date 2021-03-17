namespace Api.Domain.Entities
{
    public class ProdutoEntity : BaseEntity
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Imagem { get; set; }
    }
}
