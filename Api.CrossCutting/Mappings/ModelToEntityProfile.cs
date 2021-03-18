using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
           
             #region MesReferencia
            CreateMap<MesReferenciaModel, MesReferenciaEntity>()
              .ReverseMap();
            #endregion 

             #region Transacao
            CreateMap<TransacaoModel, TransacaoEntity>()
              .ReverseMap();
            #endregion  
        }
    }
}
