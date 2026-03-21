using Subscription.Domain.Dtos.Events;

namespace Subscription.Domain.Interfaces.Messages;

/// <summary>
/// Interface para enviar eventos para a mensageria
/// </summary>
public interface IEventPublisher
{
    /// <summary>
    /// Método para enviar um evento de 'Assinatura criada' para a mensageria
    /// </summary>
    Task PublishAsync(AssinaturaCriadaEvent @event);
}