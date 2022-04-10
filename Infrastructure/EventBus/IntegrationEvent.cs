using MediatR;

namespace Apollo.BuildingBlocks.Infrastructure.EventBus;

public class IntegrationEvent : INotification
{
    public Guid Id { get; }
    public DateTime OccuredOn { get; }

    protected IntegrationEvent(Guid id, DateTime occuredOn)
    {
        Id = id;
        OccuredOn = occuredOn;
    }
}
