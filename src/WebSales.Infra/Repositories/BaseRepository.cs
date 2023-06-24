using Microsoft.Data.SqlClient;
using System.Data;

namespace WebSales.Infra.Repositories
{
    public abstract class BaseRepository
    {
        public readonly string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=WebSalesDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        protected static async Task OpenConnection(SqlConnection connection)
        {
            await connection.OpenAsync();
        }

        protected static async Task CheckAndCloseConnection(SqlConnection connection)
        {
            if (connection?.State == ConnectionState.Open) await connection.CloseAsync();
        }
    }

    
}
