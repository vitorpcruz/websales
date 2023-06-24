using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace WebSales.Infra.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public async Task<Customer> FindByIdAsync(int id)
        {
            string query = "SELECT Customers.Id, Customers.FullName, Customers.Document, Customers.CreatedAt, Customers.Modified FROM Customers WHERE Customers.Id = @Id";

            using SqlConnection connection = new(ConnectionString);

            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@Id", id);
            Customer customer = null;

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        customer = Customer.Factory((int)reader["Id"],
                            (string)reader["FullName"],
                            (string)reader["Document"],
                            (DateTime)reader["CreateAt"],
                            (DateTime)reader["ModifiedAt"]);
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
            return customer;
        }

        public async Task AddAsync(Customer entity)
        {
            string query = "INSERT INTO Customers (FullName, Document, IsLegalPerson, CreatedAt, ModifiedAt) VALUES (@FullName, @Document, @IsLegalPerson, @CreatedAt, @ModifiedAt)";

            using SqlConnection connection = new(ConnectionString);
            SqlCommand command = new(query, connection)
            {
                CommandType = CommandType.Text
            };

            command.Parameters.AddWithValue("@FullName", entity.FullName);
            command.Parameters.AddWithValue("@Document", entity.Document);
            command.Parameters.AddWithValue("@IsLegalPerson", entity.IsLegalPerson);
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);
            command.Parameters.AddWithValue("@ModifiedAt", null);

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

        public async Task RemoveAsync(int id)
        {
            string query = "DELETE FROM Customers WHERE Customers.Id = @Id";

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

        public async Task UpdateAsync(Customer entity)
        {
            string query = "UPDATE Customer SET Customer.FullName=@FullName, Customer.Document=@Document, Customer.IsLegalPerson=@IsLegalPerson, Customer.ModifiedAt=@ModifiedAt WHERE Customer.Id = @Id";
            
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@FullName", entity.FullName);
            command.Parameters.AddWithValue("@Document", entity.Document);
            command.Parameters.AddWithValue("@IsLegalPerson", entity.IsLegalPerson);
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

        public async Task<bool> CheckIfDocumentExists(string document)
        {
            string query = "SELECT Customers.Document FROM Customers WHERE Customers.Documnet=@Document";
            
            using SqlConnection connection = new(ConnectionString);
            
            SqlCommand command = new(query, connection);
            bool result;

            command.Parameters.AddWithValue("@Document", document);

            try
            {
                await OpenConnection(connection);
                using (SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection))
                {
                    result = reader.HasRows;
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
            return result;
        }
    }
}
