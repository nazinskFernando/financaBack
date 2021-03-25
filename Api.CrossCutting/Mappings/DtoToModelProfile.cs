using Api.Domain.Dtos;
using Api.Domain.Dtos.MesReferencia;
using Api.Domain.Dtos.PlanejamentoParcelado;
using Api.Domain.Dtos.Planejamentos;
using Api.Domain.Dtos.Poupanca;
using Api.Domain.Dtos.Saida;
using Api.Domain.Dtos.Entrada;
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

            #region Entrada
            CreateMap<EntradaModel, EntradaDto>()
                .ReverseMap();
            CreateMap<EntradaModel, EntradaRetornoDto>()
                .ReverseMap();
            #endregion

            #region Saida
            CreateMap<SaidaModel, SaidaDto>()
                .ReverseMap();
            #endregion

             #region Poupanca
            CreateMap<PoupancaModel, PoupancaDto>()
                .ReverseMap();
            #endregion

             #region Planejamentos
            CreateMap<PlanejamentosModel, PlanejamentosDto>()
                .ReverseMap();
            #endregion

             #region PlanejamentoParcelado
            CreateMap<PlanejamentoParceladoModel, PlanejamentoParceladoDto>()
                .ReverseMap();
            #endregion
        }
    }
}
