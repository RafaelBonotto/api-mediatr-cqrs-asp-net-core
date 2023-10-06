using api_mediatr_cqrs.Comandos.Requests;
using api_mediatr_cqrs.Comandos.Responses;
using MediatR;

namespace api_mediatr_cqrs.Handlers
{
    public class CadastroClienteHandler : IRequestHandler<CadastroClienteRequest, CadastroClienteResponse>
    {
        public Task<CadastroClienteResponse> Handle(CadastroClienteRequest request, CancellationToken cancellationToken)
        {
            // Aqui entra a regra de cadastro de cliente
            // Abaixo simulação do retorno
            CadastroClienteResponse resultado = new()
            {
                Id = Guid.NewGuid(),
                Nome = "Bruce Wayne",
                Telefone = "(11)55661122",
                Data = DateTime.Now
            };

            return Task.FromResult(resultado);
        }
    }
}
