using DapperRepository.Data.Interfaces;
using System.Data;

namespace DapperRepository.Data
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly AppConfigurationCollection _appConfigCollection;
        public ConnectionFactory(AppConfigurationCollection appConfigCollection)
        {
            _appConfigCollection = appConfigCollection;
        }
        public IDbConnection GetConnection(string appName)
        {
            var config = _appConfigCollection[appName];
            var factory = DbProviderFactories.GetFactory(config.ProviderName);
            var conn = factory.CreateConnection();
            conn.ConnectionString = config.ConnectionString;
            conn.Open();
            return conn;
        }
        public void Dispose()
        {
        }
    }
}
