namespace Api.Domain.Models
{
    public class PoupancaModel : BaseModel
    {
        private string _name;
        public string Nome
        {
            get { return _name; }
            set { _name = value; }
        }


    }
}
