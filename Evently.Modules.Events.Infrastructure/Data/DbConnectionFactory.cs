using System.Data.Common;
using Evently.Modules.Events.Application.Abstractions.Data;
using Npgsql;

namespace Evently.Modules.Events.Infrastructure.Data;

internal sealed class DbConnectionFactory(NpgsqlDataSource source) : IDbConnectionFactory
{
    public async ValueTask<DbConnection> OpenConnectionAsync()
    {
        return await source.OpenConnectionAsync();
    }
}
