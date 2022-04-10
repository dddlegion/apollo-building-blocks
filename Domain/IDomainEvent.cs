using MediatR;

namespace Apollo.BuildingBlocks.Domain;

public interface IDomainEvent: INotification
{
    Guid Id { get; }
    DateTime OccuredOn { get; }
}
