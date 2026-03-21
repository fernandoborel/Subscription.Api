using Subscription.Domain.Dtos.Responses;

namespace Subscription.Domain.Dtos.Events;

/// <summary>
/// DTO com o modelo de dados do evento de assinatura criada
/// </summary>
public record AssinaturaCriadaEvent(
        Guid id,
        DateTime dataHora,
        AssinaturaResponse assinatura
    );
