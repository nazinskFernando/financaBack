using System;
namespace Api.Domain.Dtos.ProdutoDto
{
    public class ProdutoDto
    {
        public Guid? Id { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Imagem { get; set; }
    }
}
