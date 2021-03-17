using Api.Domain.Entities;

namespace Api.Domain.Models
{
    public class EntradaModel: TransacaoModel
    {
        private TipoOperacaoEntrada _tipoOperacaoEntrada;
        public TipoOperacaoEntrada TipoOperacaoEntrada
        {
            get { return _tipoOperacaoEntrada; }
            set { _tipoOperacaoEntrada = value; }
        }
        
    }
}
