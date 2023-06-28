using Microsoft.Data.SqlClient;
using System.Data;
using WebSales.Domain.ValueObjects;

namespace WebSales.Infra.Repositories
{
    public class SaleOrderRepository : BaseRepository
    {
        public async Task<IEnumerable<SaleOrder>> GetSalesByDateAsync(DateTime date)
        {
            string query = "SELECT SaleNumber, sum(Total) as Total FROM Sales WHERE CreatedAt=@Date GROUP BY SaleNumber";
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Date", "%" + date.ToString("yyyy-MM-dd") + "%");

            List<SaleOrder> salesList = new();

            try
            {
                await OpenConnection(connection);
                using SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        salesList.Add(ConvertToEntity(reader));
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }

            return salesList;
        }

        private static SaleOrder ConvertToEntity(SqlDataReader reader)
        {
            return new SaleOrder(
                (string)reader["SaleNumber"],
                (decimal)reader["Total"]
            );
        }
    }
}
