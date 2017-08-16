using DapperRepository.Data.Interfaces;
using System.Data;

namespace DapperRepository.Data
{
    public abstract class BaseContext : IContext
    {
        private readonly IConnectionFactory _connectionFactory;
        private IDbConnection _connection;
        private readonly string _contextName;
        public BaseContext(IConnectionFactory connectionFactory, string contextName)
        {
            _connectionFactory = connectionFactory;
            _contextName = contextName;
        }
        public IDbConnection Connection
        {
            get
            {
                _connection = _connection == null ?
                    _connectionFactory?.GetConnection(_contextName) :
                    _connection;
                return _connection;
            }
        }
        public IConnectionFactory ConnectionFactory
        {
            get
            {
                return _connectionFactory;
            }
        }
        public void Dispose()
        {
            if (_connectionFactory != null)
            {
                _connectionFactory.Dispose();
            }
        }
    }
}
