using Pagamentos.Infra.Connection.Interfaces;
using System.Data;

namespace Pagamentos.Infra.Connection
{
    public class PagamentosConnection : IPagamentosConnection
    {
        public IDbConnection CreateConnection()
        {
            throw new NotImplementedException();
        }
    }
}
