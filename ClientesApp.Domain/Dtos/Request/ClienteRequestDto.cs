namespace ClientesApp.Domain.Dtos.Request
{
    /// <summary>
    /// DTO para entrada de dados (Requisição) de clientes
    /// </summary>
    public class ClienteRequestDto
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Cpf { get; set; }
    }
}
