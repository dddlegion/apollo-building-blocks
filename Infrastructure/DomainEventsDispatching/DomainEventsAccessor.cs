using Apollo.BuildingBlocks.Domain;

namespace Apollo.BuildingBlocks.Infrastructure.DomainEventsDispatching;

public class DomainEventsAccessor : IDomainEventsAccessor
{
    public IReadOnlyCollection<IDomainEvent> GetAllDomainEvents()
    {
        throw new NotImplementedException();
    }

    public void ClearAllDomainEvents()
    {
        throw new NotImplementedException();
    }
}
