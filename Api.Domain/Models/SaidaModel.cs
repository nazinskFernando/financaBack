using Api.Domain.Entities;
using System;
namespace Api.Domain.Models
{
    public class SaidaModel : BaseModel
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

        private string _parcelas;
        public string Parcelas
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
        private Guid _isFixId;
        public Guid IsFixId
        {
            get { return _isFixId; }
            set { _isFixId = value; }
        }


        private Guid _mesReferenciaId;
        public Guid MesReferenciaId
        {
            get { return _mesReferenciaId; }
            set { _mesReferenciaId = value; }
        }

        private Guid _poupancaId;
        public Guid PoupancaId
        {
            get { return _poupancaId; }
            set { _poupancaId = value; }
        }
        private double _porcentagem;
        public double Porcentagem
        {
            get { return _porcentagem; }
            set { _porcentagem = value; }
        }
        private Guid _entradaId;
        public Guid EntradaId
        {
            get { return _entradaId; }
            set { _entradaId = value; }
        }
        private TipoOperacaoSaida _tipoOperacaoSaida;
        public TipoOperacaoSaida TipoOperacaoSaida
        {
            get { return _tipoOperacaoSaida; }
            set { _tipoOperacaoSaida = value; }
        }
    }
}
