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
            string query = "SELECT Customers.Id, Customers.FullName, Customers.Document, Customers.CreatedAt, Customers.ModifiedAt FROM Customers WHERE Customers.Id = @Id";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Id", id);
            Customer? customer = null;

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        customer = new(
                            (int)reader["Id"],
                            (string)reader["FullName"],
                            (string)reader["Document"],
                            (DateTime)reader["CreatedAt"],
                            DBNull.Value.Equals(reader["ModifiedAt"]) ? null : (DateTime)reader["ModifiedAt"]
                        );
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

        public async Task<int> AddAsync(Customer entity)
        {
            string query = "INSERT INTO Customers (FullName, Document, IsLegalPerson, CreatedAt) VALUES (@FullName, @Document, @IsLegalPerson, @CreatedAt)";
            int result;

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection)
            {
                CommandType = CommandType.Text
            };

            command.Parameters.AddWithValue("@FullName", entity.FullName);
            command.Parameters.AddWithValue("@Document", entity.Document);
            command.Parameters.AddWithValue("@IsLegalPerson", entity.IsLegalPerson);
            command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

            try
            {
                await OpenConnection(connection);
                result = await command.ExecuteNonQueryAsync();
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

        public async Task RemoveAsync(int id)
        {
            string query = "DELETE FROM Customers WHERE Customers.Id = @Id";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);
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
            string query = "UPDATE Customers SET Customers.FullName=@FullName, Customers.Document=@Document, Customers.IsLegalPerson=@IsLegalPerson, Customers.ModifiedAt=@ModifiedAt WHERE Customers.Id = @Id";
            
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Id", entity.Id);
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
            string query = "SELECT Customers.Document FROM Customers WHERE Customers.Document=@Document";
            
            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);
           
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

        public async Task<Customer> GetCustomerByDocumentAsync(string document)
        {
            string query = "SELECT Customers.Id, Customers.FullName, Customers.Document, Customers.IsLegalPerson, Customers.CreatedAt, Customers.ModifiedAt FROM Customers WHERE Customers.Document LIKE @Document";

            Customer? customer = null;

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Document", "%" + document + "%");
            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        customer = new(
                            (int)reader["Id"],
                            (string)reader["FullName"],
                            (string)reader["Document"],
                            (DateTime)reader["CreatedAt"],
                            DBNull.Value.Equals(reader["ModifiedAt"]) ? null : (DateTime)reader["ModifiedAt"]
                        );
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

        public Task<Customer> GetCustomerByFullNameAsync(string fullName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            string query = "SELECT * FROM Customers";

            List<Customer> customers = new();

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                while(await reader.ReadAsync())
                {
                    customers.Add(new(
                        (int)reader["Id"],
                        (string)reader["FullName"],
                        (string)reader["Document"],
                        (DateTime)reader["CreatedAt"],
                        DBNull.Value.Equals(reader["ModifiedAt"]) ? null : (DateTime)reader["ModifiedAt"]
                    ));
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
            return customers;
        }

        public async Task<IEnumerable<Customer>> GetCustomersByFullNameAsync(string fullName)
        {
            string query = "SELECT * FROM Customers WHERE Customers.FullName LIKE @FullName";

            List<Customer> customers = new();

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@FullName", "%"+ fullName + "%");

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                while (await reader.ReadAsync())
                {
                    customers.Add(new(
                        (int)reader["Id"],
                        (string)reader["FullName"],
                        (string)reader["Document"],
                        (DateTime)reader["CreatedAt"],
                        DBNull.Value.Equals(reader["ModifiedAt"]) ? null : (DateTime)reader["ModifiedAt"]
                    ));
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
            return customers;
        }

        public async Task<IEnumerable<Customer>> GetCustomersByDocumentAsync(string document)
        {
            string query = "SELECT * FROM Customers WHERE Customers.Document LIKE @Document";

            List<Customer> customers = new();

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Document", "%" + document + "%");

            try
            {
                await OpenConnection(connection);
                SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                while (await reader.ReadAsync())
                {
                    customers.Add(new(
                        (int)reader["Id"],
                        (string)reader["FullName"],
                        (string)reader["Document"],
                        (DateTime)reader["CreatedAt"],
                        DBNull.Value.Equals(reader["ModifiedAt"]) ? null : (DateTime)reader["ModifiedAt"]
                    ));
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
            return customers;
        }
    }
}
