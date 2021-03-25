namespace Api.Domain.Models
{
    public class PlanejamentosModel : BaseModel
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
        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private int _parcelas;
        public int Parcelas
        {
            get { return _parcelas; }
            set { _parcelas = value; }
        }
    }
}
