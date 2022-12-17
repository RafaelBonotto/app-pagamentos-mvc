using System.Data;

namespace Pagamentos.Infra.Connection.Interfaces
{
    public interface IPagamentosConnection
    {
        IDbConnection CreateConnection();
    }
}
