using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.WebInterface.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<ActionResult> Index()
        {
            var product = await _productService.GetProductsAsync();
            return View(product);
        }

        public async Task<ActionResult> Details(int id)
        {
            var product = await _productService.FindProductByIdAsync(id);

            if (product == null) 
                return RedirectToAction(nameof(Index));

            return View(product);
        }

        public ActionResult Create()
        {
            var product = new ProductDTO();
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductDTO productDto)
        {
            if (!ModelState.IsValid) return View(productDto);
            await _productService.AddProductAsync(productDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            var product = await _productService.FindProductByIdAsync(id);
            if (product == null) return RedirectToAction(nameof(Index));
            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProductDTO productDto)
        {
            if (!ModelState.IsValid) return View(productDto);
            await _productService.UpdateProductAsync(productDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task Delete(int id)
        {
            await _productService.DeleteProductAsync(id);
        }

        [HttpGet]
        public async Task<ActionResult> FindProductById(int id)
        {
            return Ok(await _productService.FindProductByIdAsync(id));
        }
    }
}
