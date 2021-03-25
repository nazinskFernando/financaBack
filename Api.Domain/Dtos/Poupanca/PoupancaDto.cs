
using System;
using Api.Domain.Entities;
namespace Api.Domain.Dtos.Poupanca
{
    public class PoupancaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        // public IEnumerable<TransacaoEntity> Transacoes { get; set; }
    }
}
