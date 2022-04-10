namespace Apollo.BuildingBlocks.Infrastructure;

public class UnitOfWork : IUnitOfWork
{
    public Task<int> CommitAsync(CancellationToken cancellationToken = default, Guid? internalCommandId = null)
    {
        throw new NotImplementedException();
    }
}
