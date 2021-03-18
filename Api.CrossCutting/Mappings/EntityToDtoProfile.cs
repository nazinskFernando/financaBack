using Api.Domain.Dtos;
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
