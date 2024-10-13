using AutoMapper;
using CHURCH.Application.Dtos.Distritos.Response;
using CHURCH.Domain.Entities;

namespace CHURCH.Application.UseCase.Mappings
{
    public class DistritosMappingProfile : Profile
    {
        public DistritosMappingProfile()
        {
            CreateMap<Distritos, GetAllDistritosResponseDto>()
                .ForMember(x => x.EstadoString, x => x.MapFrom(y => y.Estado == true ? "Activo" : "Inactivo"))
                .ReverseMap();
        }
    }
}
