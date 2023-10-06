namespace api_mediatr_cqrs.Dominio.Entidades
{
    public class Cliente
    {
        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
        }

        public Guid IdCliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
    }
}
