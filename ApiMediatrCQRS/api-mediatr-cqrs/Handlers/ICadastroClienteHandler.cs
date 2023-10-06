using api_mediatr_cqrs.Comandos.Requests;
using api_mediatr_cqrs.Comandos.Responses;

namespace api_mediatr_cqrs.Handlers
{
    public interface ICadastroClienteHandler
    {
        CadastroClienteResponse Handle(CadastroClienteRequest request);
    }
}
