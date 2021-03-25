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


            #region Entrada
            CreateMap<EntradaModel, EntradaEntity>()
              .ReverseMap();
            #endregion  

            #region Saida
            CreateMap<SaidaModel, SaidaEntity>()
              .ReverseMap();
            #endregion  

            #region Poupanca
            CreateMap<PoupancaModel, PoupancaEntity>()
              .ReverseMap();
            #endregion  

            #region Planejamentos
            CreateMap<PlanejamentosModel, PlanejamentosEntity>()
              .ReverseMap();
            #endregion 
            #region PlanejamentoParcelado
            CreateMap<PlanejamentoParceladoModel, PlanejamentoParceladoEntity>()
              .ReverseMap();
            #endregion 
        }
    }
}
