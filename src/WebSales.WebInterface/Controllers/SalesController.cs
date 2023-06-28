using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebSales.Domain.ValueObjects;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.WebInterface.Controllers
{
    public class SalesController : Controller
    {
        private readonly ISaleService _saleService;
        private readonly IValueObjectService _valueObjectsService;

        public SalesController(ISaleService saleService, IValueObjectService productSoldService)
        {
            _saleService = saleService;
            _valueObjectsService = productSoldService;
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

        public ActionResult Details(int id)
        {
            return View();
        }

        public async Task<ActionResult> RegisterSale()
        {
            var saleCustomersProducts = await _valueObjectsService.GetCustomersAndProductsForSale();
            var sale = new SaleDTO();
            ViewBag.CustomersDTO = saleCustomersProducts.CustomersForSaleDTO;
            ViewBag.ProductsDTO = saleCustomersProducts.ProductsForSaleDTO;
            return View(sale);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RegisterSale(SaleDTO sale)
        {

            if (!ModelState.IsValid) return View(sale);
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }



        public async Task<decimal> GetTodayProfit()
        {
            return await _saleService.GetTodayProfitAsync();
        }

    }
}
