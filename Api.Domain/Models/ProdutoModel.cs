namespace Api.Domain.Models
{
    public class ProdutoModel: BaseModel
    {
      
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private double _valor;
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private string _imagem;
        public string Imagem
        {
            get { return _imagem; }
            set { _imagem = value; }
        }

    }
}
