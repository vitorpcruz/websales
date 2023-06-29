using Bogus;
using Microsoft.Data.SqlClient;
using System.Data;
using WebSales.Domain.Entities;
using WebSales.Infra.Interfaces;
using WebSales.Infra.Repositories;

namespace WebSales.Tests.Infrastructure
{
    public class SaleRepositoryTests
    {
        private readonly ISaleRepository _saleRepository;
        private readonly Faker<Sale> _fakerSale;

        public SaleRepositoryTests()
        {
            _saleRepository = new SaleRepository();
            _fakerSale = new Faker<Sale>("pt_BR");
        }

        [Fact]
        public async Task SaleRepository_FindByIdAsync_ValidId_MustReturnValidSale()
        {
            var id = 1;
            var sale = await _saleRepository.FindByIdAsync(id);

            Assert.NotNull(sale);
            Assert.IsType<Sale>(sale);
        }

        [Fact]
        public async Task SaleRepository_FindByIdAsync_InvalidId_MustReturnNullSale()
        {
            var id = int.MinValue;
            var sale = await _saleRepository.FindByIdAsync(id);
            Assert.Null(sale);
        }

        [Fact]
        public async Task SaleRepository_GetSalesListByDateAsync_ValidDate_MustReturnValidListByDate()
        {
            var date = new DateTime(2023, 06, 25);
            var saleList = await _saleRepository.GetSalesListByDateAsync(date);
            Assert.True(saleList.Any());
        }

        [Fact]
        public async Task SaleRepository_GetSalesListByDateAsync_ValidDate_MustReturnEmptyListByDate()
        {
            var date = DateTime.Today;
            var saleList = await _saleRepository.GetSalesListByDateAsync(date.AddDays(5));
            Assert.False(saleList.Any());
        }

        [Fact]
        public async Task SaleRepository_GetSalesBySaleNumber_ValidInitialSaleNumber_MustReturnValidListBySaleNumber()
        {
            // var date = new DateTime(2023, 06, 25).ToString("yyyyMMdd");
            // var saleList = await _saleRepository.GetSaleBySaleNumberAsync(date);
            // Assert.True(saleList.Any());
        }

        [Fact]
        public async Task SaleRepository_GetSalesBySaleNumber_InvalidInitialSaleNumber_MustReturnEmptyListBySaleNumber()
        {
            // var date = new DateTime(2500, 06, 25).ToString("yyyyMMdd");
            // var saleList = await _saleRepository.GetSaleBySaleNumberAsync(date);
            // Assert.False(saleList.Any());
        }

        [Fact]
        public async Task SaleRepository_GetProfitByDateAsync_ValidDate_MustReturnValidProfitByDate()
        {
            var date = new DateTime(2023, 06, 25);
            var result = await _saleRepository.GetProfitByDateAsync(date);
            Assert.IsType<decimal>(result);
            Assert.True(result >= 1);
        }

        [Fact]
        public async Task SaleRepository_GetProfitByDateAsync_InvalidDate_MustReturnZero()
        {
            var date = new DateTime(2500, 06, 25);
            var result = await _saleRepository.GetProfitByDateAsync(date);
            Assert.IsType<decimal>(result);
            Assert.True(result == 0);
        }

        [Fact]
        public async Task SaleRepository_RemoveAsync_ValidSale_MustDeleteValidSalid()
        {
            string selectString = "SELECT TOP 1 Sales.Id FROM Sales ORDER BY Sales.Id DESC";
            using SqlConnection connection = new(BaseRepository.ConnectionString);
            using SqlCommand command = new(selectString, connection);
            int idResult = 0;

            try
            {
                await BaseRepository.OpenConnection(connection);
                using SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        idResult = (int)reader["Id"];
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await BaseRepository.CheckAndCloseConnection(connection) ;
            }

            await _saleRepository.RemoveAsync(idResult);
            var sale = await _saleRepository.FindByIdAsync(idResult);

            Assert.Null(sale);
        }

        [Fact]
        public async Task SaleRepository_RemoveAsync_InvalidSale_MustNotDeleteNonExistingSale()
        {
            int id = 1000000;
            await _saleRepository.RemoveAsync(id);
            var result = await _saleRepository.FindByIdAsync(id);
            Assert.Null(result);
        }

        [Fact] async Task SaleRepository_AddAsync_MustRegisterValidSale()
        {
            var newSale = new Sale(10, 10, 100, false, 10, 10);
            await _saleRepository.AddAsync(newSale);

            var salesRegistered = await _saleRepository.GetSalesListByDateAsync(DateTime.Today);
            var firstRegister = salesRegistered.First();

            Assert.Equal(firstRegister.ProductId, newSale.ProductId);
            Assert.Equal(firstRegister.CustomerId, newSale.CustomerId);
            Assert.Equal(firstRegister.ProductQuantity, newSale.ProductQuantity);
        }

        [Fact]
        async Task SaleRepository_UpdateAsync_ValidId_MustUpdateValidSale()
        {
            string selectString = "SELECT TOP 1 Sales.Id FROM Sales ORDER BY Sales.Id DESC";
            using SqlConnection connection = new(BaseRepository.ConnectionString);
            using SqlCommand command = new(selectString, connection);
            int idResult = 0;

            try
            {
                await BaseRepository.OpenConnection(connection);
                using SqlDataReader reader = await command.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                if (reader.HasRows)
                {
                    if (await reader.ReadAsync())
                    {
                        idResult = (int)reader["Id"];
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                await BaseRepository.CheckAndCloseConnection(connection);
            }

            var sale = await _saleRepository.FindByIdAsync(idResult);
            sale.CancelSale();
            await _saleRepository.UpdateAsync(sale);
            var cancelledSale = await _saleRepository.FindByIdAsync(idResult);

            Assert.Equal(sale.SaleCancelled, cancelledSale.SaleCancelled);
            Assert.Equal(sale.SaleNumber, sale.SaleNumber);
        }
    }
}
