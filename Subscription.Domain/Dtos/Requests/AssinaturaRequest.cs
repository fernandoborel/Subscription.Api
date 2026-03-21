namespace Subscription.Domain.Dtos.Requests;

/// <summary>
/// DTO para entrada de dados de assinatura.
/// </summary>
public record AssinaturaRequest(
        Guid clienteId,
        Guid planoId
    );