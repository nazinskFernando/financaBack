using Api.Domain.Dtos;
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
