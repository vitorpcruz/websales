using Microsoft.Data.SqlClient;
using System.Data;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;

namespace WebSales.Infra.Repositories
{
    public class SaleRepository : BaseRepository, ISaleRepository
    {
        public async Task<decimal> GetProfitByDateAsync(DateTime date)
        {
            string query = "SELECT SUM(Sales.Total) as 'Total' FROM Sales WHERE CreatedAt LIKE @Date";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Date", "%" + date.ToString("yyyy-MM-dd") + "%");

            decimal profitability = 0;

            try
            {
                await OpenConnection(connection);

                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        if (!DBNull.Value.Equals(reader["Total"]))
                            profitability = (decimal)reader["Total"];
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }
            return profitability;
        }

        public async Task<Sale> FindByIdAsync(int id)
        {
            string query = "SELECT * FROM Sales WHERE Sales.Id=@Id";
            Sale sale = null;

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Id", id);
                
            try
            {
                await OpenConnection(connection);
                using SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                    
                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        sale = ConvertToEntity(reader);
                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }
            return sale;
        }

        public async Task AddAsync(Sale entity)
        {
            string query = "INSERT INTO Sales VALUES (@SaleNumber, @ProductPriceAtMoment, @ProductQuantity, @Total, @SaleCancelled, @CustomerId, @ProductId, getdate(), null)";
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection) { CommandType = CommandType.Text };

            command.Parameters.AddWithValue("@SaleNumber", entity.SaleNumber);
            command.Parameters.AddWithValue("@ProductPriceAtMoment", entity.ProductPriceAtMoment);
            command.Parameters.AddWithValue("@ProductQuantity", entity.ProductQuantity);
            command.Parameters.AddWithValue("@Total", entity.Total);
            command.Parameters.AddWithValue("@SaleCancelled", entity.SaleCancelled);
            command.Parameters.AddWithValue("@CustomerId", entity.CustomerId);
            command.Parameters.AddWithValue("@ProductId", entity.ProductId);

            try
            {
                await OpenConnection(connection);
                await command.ExecuteNonQueryAsync();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }
        }

        public async Task<IEnumerable<Sale>> GetSalesListByDateAsync(DateTime date)
        {
            string query = "SELECT * FROM Sales WHERE Sales.CreatedAt LIKE @Date";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Date", "%" + date.ToString("yyyy-MM-dd") + "%");

            List<Sale> salesList = new List<Sale>();

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

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

        public async Task<IEnumerable<Sale>> GetSalesBySaleNumberAsync(string saleNumber)
        {
            string query = "SELECT * FROM Sales WHERE Sales.SaleNumber LIKE @SaleNumber";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@SaleNumber", "%" + saleNumber + "%");

            List<Sale> salesList = new();

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

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

        public async Task RemoveAsync(int id)
        {
            string query = "DELETE FROM Sales WHERE Sales.Id = @Id";

            using SqlConnection connection = new(ConnectionString);
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@Id", id);

            try
            {
                await OpenConnection(connection);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }
        }

        public async Task UpdateAsync(Sale entity)
        {
            if (entity == null) return;


            string query = "UPDATE Sales SET Sales.SaleCancelled=@SaleCancelled, Sales.ModifiedAt=@ModifiedAt WHERE Sales.SaleNumber=@SaleNumber";
            
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@SaleNumber", entity.SaleNumber);
            command.Parameters.AddWithValue("@SaleCancelled", entity.SaleCancelled);
            command.Parameters.AddWithValue("@ModifiedAt", entity.ModifiedAt);

            try
            {
                await OpenConnection(connection);
                await command.ExecuteNonQueryAsync();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }
        }

        private static Sale ConvertToEntity(SqlDataReader reader)
        {
            return new Sale(
                (int)reader["Id"],
                (string)reader["SaleNumber"],
                (decimal)reader["ProductPriceAtMoment"],
                (int)reader["ProductQuantity"],
                (decimal)reader["Total"],
                (bool)reader["SaleCancelled"],
                DBNull.Value.Equals(reader["CustomerId"]) ? null : (int)reader["CustomerId"],
                DBNull.Value.Equals(reader["ProductId"]) ? null : (int)reader["ProductId"],
                (DateTime)reader["CreatedAt"],
                DBNull.Value.Equals(reader["ModifiedAt"]) ? null : (DateTime)reader["ModifiedAt"]
            );
        }
    }
}
