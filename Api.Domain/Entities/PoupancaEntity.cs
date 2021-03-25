using System.Collections.Generic;
namespace Api.Domain.Entities
{
    public class PoupancaEntity: BaseEntity
    {
        public string Nome { get; set; }
        public IEnumerable<EntradaEntity> TransacoesEntrada { get; set; }
        public IEnumerable<SaidaEntity> TransacoesSaida { get; set; }
    }
}
