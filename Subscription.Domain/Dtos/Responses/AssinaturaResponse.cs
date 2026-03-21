namespace Subscription.Domain.Dtos.Responses;

/// <summary>
/// DTO para saída de dados de assinatura.
/// </summary>
public record AssinaturaResponse(
        Guid id,
        ClienteResponse cliente,
        PlanoResponse plano,
        DateTime dataInicio,
        decimal valor,
        string status
    );