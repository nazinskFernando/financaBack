using Api.Domain.Dtos;
using Api.Domain.Dtos.ProdutoDto;
using Api.Domain.Dtos.Entrada;
using Api.Domain.Dtos.Saida;
using Api.Domain.Dtos.MesReferencia;
using Api.Domain.Dtos.Transacao;
using Api.Domain.Entities;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
           #region Produto           
            CreateMap<ProdutoDto, ProdutoEntity>()
            .ReverseMap();
            CreateMap<ProdutoRetornoDto, ProdutoEntity>()
            .ReverseMap();
            #endregion

             #region Entrada           
            CreateMap<EntradaDto, EntradaEntity>()
            .ReverseMap();
            #endregion

            #region Saida           
            CreateMap<SaidaDto, SaidaEntity>()
            .ReverseMap();
            #endregion

            #region MesReferencia           
            CreateMap<MesReferenciaDto, MesReferenciaEntity>()
            .ReverseMap();
            #endregion

             #region Transacao           
            CreateMap<TransacaoDto, TransacaoEntity>()
            .ReverseMap();
            #endregion
            
        }
    }
}
