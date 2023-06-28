using Microsoft.EntityFrameworkCore;
using WebSales.Infra.Data;
using WebSales.Domain.ValueObjects;
using Microsoft.Data.SqlClient;
using System.Data;
using WebSales.Infra.Interfaces;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WebSales.Infra.Repositories
{
    public class ValueObjectsRepository : BaseRepository, IValueObjectsRepository
    {
        private readonly ApplicationDbContext _context;

        public ValueObjectsRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProductSold>> ProductsPurchasedByCustomerAsync(int id)
        {
            var query = from p in _context.Products
                        join s in _context.Sales on p.Id equals s.ProductId
                        join c in _context.Customers on s.CustomerId equals c.Id
                        where c.Id == id
                        select new ProductSold(p.Id, p.Name);
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<BestSellingProduct>> BestSeillingProductsAsync()
        {
            var query = from p in _context.Products
                        join s in _context.Sales on p.Id equals s.ProductId into salesGroup
                        from sale in salesGroup
                        group new { p, sale } by p.Name into groupedData
                        orderby groupedData.Sum(x => x.sale.Total) descending
                        select new BestSellingProduct(groupedData.Key, groupedData.Sum(x => x.sale.Total));

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<PurchaseByValidCustomer>> PurchasesMadebyValidCustomers()
        {
            string query = "SELECT Customers.Id, Customers.FullName, Customers.Document, Sales.SaleNumber FROM Customers INNER JOIN Sales ON Customers.Id = Sales.CustomerId ORDER BY Customers.Id DESC";

            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            List<PurchaseByValidCustomer> purchasesByValidCustomers = new();

            try
            {
                await OpenConnection(connection);
                using SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        purchasesByValidCustomers.Add(ConvertToPurchaseByValidCustomer(reader));
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

            return purchasesByValidCustomers;
        }

        public async Task<IEnumerable<SaleComplete>> GetAllSalesByDateAsync(DateTime date)
        {
            string query = 
                @"SELECT 
                    Sales.SaleNumber, 
                    Sales.ProductPriceAtMoment, 
                    Sales.ProductQuantity, 
                    Sales.Total, 
                    Sales.SaleCancelled,
                    Products.Name as 'ProductName', 
                    Customers.FullName as 'CustomerFullName'
                FROM Sales
                LEFT JOIN Products ON Sales.ProductId = Products.Id
                LEFT JOIN Customers ON Sales.CustomerId = Customers.Id
                WHERE Sales.CreatedAt LIKE @Date";


            using SqlConnection connection = new(ConnectionString);
            using SqlCommand command = new(query, connection);

            command.Parameters.AddWithValue("@Date", $"%{date:yyyy-MM-dd}%");

            List<SaleComplete> salesComplete = new();

            try
            {
                await OpenConnection(connection);
                using SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    while (await reader.ReadAsync())
                    {
                        salesComplete.Add(ConvertToSaleComplete(reader));
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

            return salesComplete;

        }

        public async Task<SaleCustomerProduct> GetCustomersAndProductsForSale()
        {
            string queryCustomers = "SELECT Customers.Id, Customers.FullName FROM Customers ORDER BY Customers.Id";
            string queryProducts = "SELECT Products.Id, Products.Name, Products.Quantity, Products.Price FROM Products ORDER BY Products.Id";

            using SqlConnection connection = new(ConnectionString);

            using SqlCommand commandQueryCustomers = new(queryCustomers, connection);
            using SqlCommand commandQueryProducts = new(queryProducts, connection);

            List<CustomerForSale> customers = new();
            List<ProductForSale> products = new();

            await OpenConnection(connection);

            try
            {

                using SqlDataReader readerCustomers = await commandQueryCustomers.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (readerCustomers.HasRows)
                {
                    while (await readerCustomers.ReadAsync())
                    {
                        customers.Add(ConvertToCustomerForSale(readerCustomers));
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

            await OpenConnection(connection);
            try
            {
                using SqlDataReader readerProducts = await commandQueryProducts.ExecuteReaderAsync(CommandBehavior.CloseConnection);
                if (readerProducts.HasRows)
                {
                    while (await readerProducts.ReadAsync())
                    {
                        products.Add(ConvertToProductForSale(readerProducts));
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


            SaleCustomerProduct saleCustomersProducts = new(customers, products);
            return saleCustomersProducts;
        }

        private static CustomerForSale ConvertToCustomerForSale(SqlDataReader reader)
        {
            int? tempId = DBNull.Value.Equals(reader["Id"]) ? null : (int)reader["Id"];
            string? tempFullName = DBNull.Value.Equals(reader["FullName"]) ? null : (string)reader["FullName"];
            return new CustomerForSale(tempId, tempFullName);
        }

        private static ProductForSale ConvertToProductForSale(SqlDataReader reader)
        {
            int? tempId = DBNull.Value.Equals(reader["Id"]) ? null : (int)reader["Id"];
            string? tempName = DBNull.Value.Equals(reader["Name"]) ? null : (string)reader["Name"];
            int? tempQuantity = DBNull.Value.Equals(reader["Quantity"]) ? null : (int)reader["Quantity"];
            decimal? tempPrice = DBNull.Value.Equals(reader["Price"]) ? null : (decimal)reader["Price"];
            return new ProductForSale(tempId, tempName, tempQuantity, tempPrice);
        }

        private static PurchaseByValidCustomer ConvertToPurchaseByValidCustomer(SqlDataReader reader)
        {
            int? tempId = DBNull.Value.Equals(reader["Id"]) ? null : (int)reader["Id"];
            string? tempCustomerFullName = DBNull.Value.Equals(reader["FullName"]) ? null : (string)reader["FullName"];
            string? tempCustomerDocument = DBNull.Value.Equals(reader["Document"]) ? null : (string)reader["Document"];
            string? tempSaleNumber = DBNull.Value.Equals(reader["SaleNumber"]) ? null : (string)reader["SaleNumber"];

            return new PurchaseByValidCustomer(tempId, tempCustomerFullName, tempCustomerDocument, tempSaleNumber);
        }

        private static SaleComplete ConvertToSaleComplete(SqlDataReader reader)
        {
           string? tempSaleNumber = DBNull.Value.Equals(reader["SaleNumber"]) ? null : (string)reader["SaleNumber"];
           decimal? tempProductPriceAtMoment = DBNull.Value.Equals(reader["ProductPriceAtMoment"]) ? null : (decimal)reader["ProductPriceAtMoment"];
           int? tempProductQuantity = DBNull.Value.Equals(reader["ProductQuantity"]) ? null : (int)reader["ProductQuantity"];
           decimal? tempTotal = DBNull.Value.Equals(reader["Total"]) ? null : (decimal)reader["Total"];
           string? tempProductName = DBNull.Value.Equals(reader["ProductName"]) ? null : (string)reader["ProductName"];
           string? tempCustomerFullName = DBNull.Value.Equals(reader["CustomerFullName"]) ? null : (string)reader["CustomerFullName"];

            return new SaleComplete(
                tempSaleNumber,
                tempProductPriceAtMoment,
                tempProductQuantity,
                tempTotal,
                tempProductName,
                tempCustomerFullName
            );
        }
    }
}
