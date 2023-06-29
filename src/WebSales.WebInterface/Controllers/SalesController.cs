using Microsoft.AspNetCore.Mvc;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.WebInterface.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISaleService _saleService;
        private readonly IProductService _productService;
        private readonly IValueObjectService _valueObjectsService;

        public SalesController(ISaleService saleService, IValueObjectService productSoldService, IProductService productService)
        {
            _saleService = saleService;
            _valueObjectsService = productSoldService;
            _productService = productService;
        }

        public async Task<ActionResult> Index()
        {
            var productList = await _valueObjectsService.GetAllSalesByDateAsync(DateTime.Now);
            return View(productList);
        }

        public async Task<ActionResult> BestSeillingProducts()
        {
            var bestProductList = await _valueObjectsService.BestSeillingProductsAsync();
            return View(bestProductList);
        }

        public async Task<ActionResult> PurchasesMadebyValidCustomers()
        {
            var sales = await _valueObjectsService.PurchasesMadebyValidCustomers();
            return View(sales);
        }

        public async Task<IActionResult> RegisterSale(string? saleNumber)
        {
            SaleDTO? sale = null;
            if (saleNumber != null)
                sale = await _saleService.GetSaleBySaleNumber(saleNumber);

            await GetSaleCustomerProductsAndViewBags();
            return View(sale);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RegisterSale(SaleDTO? saleDto)
        {
            var product = await _productService.FindProductByIdAsync(saleDto.ProductId.Value);

            if (saleDto.ProductQuantity > product.Quantity)
            {
                ModelState.AddModelError("ProductQuantity", "The product quantity cannot be greater than product stock quantity");
                await GetSaleCustomerProductsAndViewBags();
                return View(saleDto);
            }

            if (!ModelState.IsValid) return View(saleDto);
            await _saleService.RegisterSalesAsync(saleDto);
            await _productService.ChangeStockValuesAsync(saleDto.ProductId.Value, saleDto.ProductQuantity.Value);
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Details(string? saleNumber)
        {
            var sale = await _saleService.GetSaleBySaleNumber(saleNumber);
            if (saleNumber == null) return RedirectToAction(nameof(Index));
            return View(sale);
        }

        public async Task<ActionResult> Edit(int id)
        {
            await GetSaleCustomerProductsAndViewBags();
            return RedirectToAction(nameof(RegisterSale));
        }

        private async Task GetSaleCustomerProductsAndViewBags()
        {
            var saleCustomersProducts = await _valueObjectsService.GetCustomersAndProductsForSale();
            ViewBag.CustomersDTO = saleCustomersProducts.CustomersForSaleDTO;
            ViewBag.ProductsDTO = saleCustomersProducts.ProductsForSaleDTO;
        }

        [HttpGet]
        public async Task<decimal> GetTodayProfit()
        {
            return await _saleService.GetTodayProfitAsync();
        }

        [HttpPost]
        public async Task CancelSaleBySaleNumber(string? q)
        {
            await _saleService.CancelSaleBySaleNumberAsync(q);
        }

        [HttpPost]
        public async Task RevertCancelledSaleBySaleNumber(string? q)
        {
            await _saleService.RevertCancelledSaleBySaleNumberAsync(q);
        }

        [HttpDelete]
        public async Task DeleteSale(int? id)
        {
            await _saleService.DeleteSaleAsync(id.Value);
        }
    }
}
