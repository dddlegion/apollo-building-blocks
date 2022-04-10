namespace Apollo.BuildingBlocks.Domain;

using MediatR;

public interface IDomainEvent: INotification
{
    Guid Id { get; }
    DateTime OccuredOn { get; }
}
