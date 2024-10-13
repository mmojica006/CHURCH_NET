using CHURCH.Application.UseCase.UseCases.Distritos.Queries.GetAllQuery;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CHURCH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistritosController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DistritosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ListDistritos()
        {
            var response = await _mediator.Send(new GetAllDistritosQuery());
            return Ok(response);
        }
    }
}
