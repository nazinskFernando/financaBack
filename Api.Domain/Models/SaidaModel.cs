using Api.Domain.Entities;

namespace Api.Domain.Models
{
    public class SaidaModel : TransacaoModel
    {
        private TipoOperacaoSaida _tipoOperacaoSaida;
        public TipoOperacaoSaida TipoOperacaoSaida
        {
            get { return _tipoOperacaoSaida; }
            set { _tipoOperacaoSaida = value; }
        }

    }
}
