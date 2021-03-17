using Api.Domain.Entities;
using Api.Domain.Models;
using AutoMapper;

namespace Api.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
             #region Produto
            CreateMap<ProdutoModel, ProdutoEntity>()
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
