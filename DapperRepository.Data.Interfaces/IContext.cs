using System;
using System.Data;

namespace DapperRepository.Data.Interfaces
{
    public interface IContext : IDisposable
    {
        IDbConnection Connection
        {
            get;
        }
    }
}
