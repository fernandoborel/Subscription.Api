namespace Subscription.Domain.Dtos.Responses;

/// <summary>
/// DTO para saída de dados de cliente
/// </summary>
public record ClienteResponse(
        Guid id,
        string nome,
        string email,
        DateTime dataCadastro,
        string status
    );