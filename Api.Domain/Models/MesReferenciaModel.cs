namespace Api.Domain.Models
{
    public class MesReferenciaModel : BaseModel
    {
        private int _mes;
        public int Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        private int _ano;
        public int Ano
        {
            get { return _ano; }
            set { _ano = value; }
        }


    }
}
