namespace Api.Domain.Models
{
    public class TransacaoModel
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

        private bool _isPago;
        public bool IsPago
        {
            get { return _isPago; }
            set { _isPago = value; }
        }
        private bool _isFixa;
        public bool IsFixa
        {
            get { return _isFixa; }
            set { _isFixa = value; }
        }



    }
}
