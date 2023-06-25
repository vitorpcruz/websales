using Microsoft.Data.SqlClient;
using System.Data;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;

namespace WebSales.Infra.Repositories
{
    public class SaleRepository : BaseRepository, ISaleRepository
    {
        public async Task<double> GetProfitByDateAsync(DateTime date)
        {
            string query = "SELECT SUM(Sales.Total) as Value FROM Sales WHERE CreatedAt=@Date";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Date", date.ToString("d"));

            double profitability = 0.0;

            try
            {
                await OpenConnection(connection);

                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows) 
                    if (await reader.ReadAsync())
                        profitability = (double)reader["Value"];
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
            string query = "SELECT * FROM Sale WHERE Sale.Id=@Id";
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
                        sale = new Sale(
                            (int)reader["Id"],
                            (string)reader["SaleNumber"],
                            (int)reader["CustomerId"],
                            (int)reader["ProductId"],
                            (int)reader["Quantity"],
                            (double)reader["Total"],
                            (DateTime)reader["CreatedAt"],
                            (DateTime)reader["ModifiedAt"]);
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

        public async Task<int> AddAsync(Sale entity)
        {
            string query = "INSERT INTO Sales (SaleNumber, CustomerId, ProductId, Quantity, Total, CreatedAt, ModifiedAt) VALUES (@SaleNumber, @CustomerId, @ProductId, @Quantity, @Total, @CreatedAt, @ModifiedtAt)";
            int result;
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection) { CommandType = CommandType.Text };

            command.Parameters.AddWithValue("@SaleNumber", entity.SaleNumber);
            command.Parameters.AddWithValue("@CustomerId", entity.CustomerId);
            command.Parameters.AddWithValue("@ProductId", entity.ProductId);
            command.Parameters.AddWithValue("@Quantity", entity.Quantity);
            command.Parameters.AddWithValue("@Total", entity.Total);
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@ModifiedAt", null);

            try
            {
                await OpenConnection(connection);
                result = await command.ExecuteNonQueryAsync();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                await CheckAndCloseConnection(connection);
            }
            return result;
        }

        public async Task<IEnumerable<Sale>> GetSalesListByDateAsync(DateTime date)
        {
            string query = "SELECT * FROM Sales WHERE CreatedAt=@Date";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Date", date.ToString("d"));

            List<Sale> salesList = null;

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        salesList.Add(
                            Sale.Factory(
                            (int)reader["Id"],
                            (string)reader["OrderNumber"],
                            (int)reader["CustomerId"],
                            (int)reader["ProductId"],
                            (int)reader["Quantity"],
                            (double)reader["Total"],
                            (DateTime)reader["CreatedAt"],
                            (DateTime)reader["ModifiedAt"]
                        ));
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
            string query = "SELECT * FROM Sales WHERE Sales.SaleNumber=@SaleNumber";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@SaleNumber", saleNumber);

            List<Sale> salesList = null;

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        salesList.Add(
                            Sale.Factory(
                            (int)reader["Id"],
                            (string)reader["OrderNumber"],
                            (int)reader["CustomerId"],
                            (int)reader["ProductId"],
                            (int)reader["Quantity"],
                            (double)reader["Total"],
                            (DateTime)reader["CreatedAt"],
                            (DateTime)reader["ModifiedAt"]
                        ));
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
            string query = "UPDATE Sales SET Sales.SaleNumber=@SaleNumber, Sales.CustomerId=@CustomerId, Sales.ProductId=@ProductId, Sales.Quantity=@Quantity, Sales.Total=@Total, Sales.ModifiedAt=@ModifiedAt WHERE Sales.Id=@Id";
            
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Id", entity.Id);
            command.Parameters.AddWithValue("@SaleNumber", entity.SaleNumber);
            command.Parameters.AddWithValue("@CustomerId", entity.CustomerId);
            command.Parameters.AddWithValue("@ProductId", entity.ProductId);
            command.Parameters.AddWithValue("@Quantity", entity.Quantity);
            command.Parameters.AddWithValue("@Total", entity.Total);
            command.Parameters.AddWithValue("@ModifiedAt", DateTime.Now);

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
    }
}
