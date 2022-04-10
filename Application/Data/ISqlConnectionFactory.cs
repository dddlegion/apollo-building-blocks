using System.Data;

namespace Apollo.BuildingBlocks.Application.Data;

public interface ISqlConnectionFactory
{
    IDbConnection GetOpenConnection();
    IDbConnection CreateNewConnection();
    string GetConnectionString();
}
