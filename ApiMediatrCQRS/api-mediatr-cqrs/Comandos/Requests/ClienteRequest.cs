using api_mediatr_cqrs.Comandos.Responses;
using MediatR;

namespace api_mediatr_cqrs.Comandos.Requests
{
    public class CadastroClienteRequest : IRequest<CadastroClienteResponse>
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
