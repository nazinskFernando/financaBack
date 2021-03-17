using Api.Domain.Dtos;
using Api.Domain.Dtos.ProdutoDto;
using Api.Domain.Dtos.Entrada;
using Api.Domain.Dtos.Saida;
using Api.Domain.Dtos.MesReferencia;
using Api.Domain.Dtos.Transacao;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region Produto
            CreateMap<ProdutoModel, ProdutoDto>()
                .ReverseMap();
            CreateMap<ProdutoModel, ProdutoRetornoDto>()
                .ReverseMap();
            #endregion

             #region Entrada
            CreateMap<EntradaModel, EntradaDto>()
                .ReverseMap();
            #endregion

            #region Saida
            CreateMap<SaidaModel, SaidaDto>()
                .ReverseMap();
            #endregion

             #region MesReferencia
            CreateMap<MesReferenciaModel, MesReferenciaDto>()
                .ReverseMap();
            #endregion

            #region Transacao
            CreateMap<TransacaoModel, TransacaoDto>()
                .ReverseMap();
            #endregion
        }
    }
}
