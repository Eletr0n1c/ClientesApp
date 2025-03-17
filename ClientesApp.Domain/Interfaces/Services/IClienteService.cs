using ClientesApp.Domain.Dtos.Request;
using ClientesApp.Domain.Dtos.Response;

namespace ClientesApp.Domain.Interfaces.Services
{
    /// <summary>
    /// Definição dos métodos abstratos para
    /// regras de negócio com a entidade 'Cliente'.
    /// </summary>
    public interface IClienteService
    {
        ClienteResponseDto Incluir(ClienteRequestDto dto);
        ClienteResponseDto Alterar(Guid id, ClienteRequestDto dto);
        ClienteResponseDto Excluir(Guid Id);
        List<ClienteResponseDto> Consultar();
        ClienteResponseDto ObterPorId(Guid Id);

    }
}
