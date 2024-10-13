using CHURCH.Application.Dtos.Distritos.Response;
using CHURCH.Application.UseCase.Commons.Bases;
using MediatR;

namespace CHURCH.Application.UseCase.UseCases.Distritos.Queries.GetAllQuery
{
    public class GetAllDistritosQuery : IRequest<BaseResponse<IEnumerable<GetAllDistritosResponseDto>>>
    {
    }
}
