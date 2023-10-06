using api_mediatr_cqrs.Comandos.Requests;
using api_mediatr_cqrs.Comandos.Responses;
using api_mediatr_cqrs.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api_mediatr_cqrs.Controllers
{
    [Route("v1/cliente")]
    [ApiController]    
    public class ClienteController : ControllerBase
    {

        [HttpPost("cadastro")]
        public async Task<CadastroClienteResponse> CadastrarAsync(
            [FromServices] IMediator handler,
            [FromBody] CadastroClienteRequest req)
        {
            return await handler.Send(req);
        } 
    }
}
