using AutoMapper;
using CHURCH.Application.Dtos.Distritos.Response;
using CHURCH.Application.Interface;
using CHURCH.Application.UseCase.Commons.Bases;
using MediatR;

namespace CHURCH.Application.UseCase.UseCases.Distritos.Queries.GetAllQuery
{
    public class GetAllDistritosHandler : IRequestHandler<GetAllDistritosQuery, BaseResponse<IEnumerable<GetAllDistritosResponseDto>>>
    {
        private readonly IDistritoRepository _distritoRepository;
        private readonly IMapper _mapper;

        public GetAllDistritosHandler(IDistritoRepository distritoRepository, IMapper mapper)
        {
            _distritoRepository = distritoRepository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<IEnumerable<GetAllDistritosResponseDto>>> Handle(GetAllDistritosQuery request, CancellationToken cancellationToken)
        {
            var response = new BaseResponse<IEnumerable<GetAllDistritosResponseDto>>();
            try
            {
                var distritos = await _distritoRepository.ListDistritos();
                if (distritos is not null)
                {
                    response.IsSuccess = true;
                    response.Data = _mapper.Map<IEnumerable<GetAllDistritosResponseDto>>(distritos);
                    response.Message = "Consulta Exitosa!!!";
                }


            }
            catch (Exception ex) 
            {
                response.Message = ex.ToString();
            }
            return response;
        }
    }
}
