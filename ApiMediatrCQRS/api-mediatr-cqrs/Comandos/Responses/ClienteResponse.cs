﻿namespace api_mediatr_cqrs.Comandos.Responses
{
    public class CadastroClienteResponse
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime Data { get; set; }
    }
}
