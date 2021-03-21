using Api.Domain.Entities;
using System;
namespace Api.Domain.Models
{
    public class TransacaoModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }
        
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
        

        private TipoOperacao _tipoOperacao;
        public TipoOperacao TipoOperacao
        {
            get { return _tipoOperacao; }
            set { _tipoOperacao = value; }
        }

        private TipoOperacaoSaida _tipoOperacaoSaida;
        public TipoOperacaoSaida TipoOperacaoSaida
        {
            get { return _tipoOperacaoSaida; }
            set { _tipoOperacaoSaida = value; }
        }

        private TipoOperacaoEntrada _tipoOperacaoEntrada;
        public TipoOperacaoEntrada TipoOperacaoEntrada
        {
            get { return _tipoOperacaoEntrada; }
            set { _tipoOperacaoEntrada = value; }
        }
        

    }
}
