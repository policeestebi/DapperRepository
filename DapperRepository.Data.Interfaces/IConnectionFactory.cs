using System;
using System.Data;

namespace DapperRepository.Data.Interfaces
{
    public interface IConnectionFactory : IDisposable
    {
        IDbConnection GetConnection(string connectionName);
    }
}
