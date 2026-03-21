namespace Subscription.Domain.Dtos.Responses;

/// <summary>
/// DTO para saída de dados de plano
/// </summary>
public record PlanoResponse(
        Guid id,
        string nome,
        decimal valorMensal,
        string periodicidade
    );