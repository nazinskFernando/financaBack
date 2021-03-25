using Api.Domain.Dtos;
using Api.Domain.Dtos.MesReferencia;
using Api.Domain.Dtos.Entrada;
using Api.Domain.Dtos.Poupanca;
using Api.Domain.Dtos.Saida;
using Api.Domain.Dtos.Planejamentos;
using Api.Domain.Dtos.PlanejamentoParcelado;
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

            #region Entrada           
            CreateMap<EntradaDto, EntradaEntity>()
            .ReverseMap();
            CreateMap<EntradaRetornoDto, EntradaEntity>()
            .ReverseMap();
            #endregion

             #region Saida           
            CreateMap<SaidaDto, SaidaEntity>()
            .ReverseMap();
            #endregion

             #region Poupanca           
            CreateMap<PoupancaDto, PoupancaEntity>()
            .ReverseMap();
            #endregion

             #region Planejamentos           
            CreateMap<PlanejamentosDto, PlanejamentosEntity>()
            .ReverseMap();
            #endregion

             #region PlanejamentoParcelado           
            CreateMap<PlanejamentoParceladoDto, PlanejamentoParceladoEntity>()
            .ReverseMap();
            #endregion
            
        }
    }
}
