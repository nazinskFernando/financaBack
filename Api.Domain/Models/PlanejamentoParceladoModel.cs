using System;
namespace Api.Domain.Models
{
    public class PlanejamentoParceladoModel : BaseModel
    {
        private double _valor;
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }

        private int _parcelaTotal;
        public int ParcelaTotal
        {
            get { return _parcelaTotal; }
            set { _parcelaTotal = value; }
        }

        private int _parcelaAtual;
        public int ParcelaAtual
        {
            get { return _parcelaAtual; }
            set { _parcelaAtual = value; }
        }

        private Guid _mesReferenciaId;
        public Guid MesReferenciaId
        {
            get { return _mesReferenciaId; }
            set { _mesReferenciaId = value; }
        }

        private Guid _planejamentoId;
        public Guid PlanejamentoId
        {
            get { return _planejamentoId; }
            set { _planejamentoId = value; }
        }


    }
}
