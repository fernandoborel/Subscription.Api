namespace Subscription.Domain.Dtos.Requests;

/// <summary>
/// DTO para entrada de dados de cliente.
/// </summary>
public record ClienteRequest(
        string nome,
        string email
    );