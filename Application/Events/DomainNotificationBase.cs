using Apollo.BuildingBlocks.Domain;

namespace Apollo.BuildingBlocks.Application.Events;

public class DomainNotificationBase<T> : IDomainEventNotification<T> where T : IDomainEvent
{
    public Guid Id { get; }
    public T DomainEvent { get; }

    public DomainNotificationBase(Guid id, T domainEvent)
    {
        Id = id;
        DomainEvent = domainEvent;
    }
}
