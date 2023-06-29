using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using WebSales.Domain.Entities;
using WebSales.Services.DTOs;
using WebSales.Services.Interfaces;

namespace WebSales.WebInterface.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;
        private readonly IValueObjectService _valueObjectService;

        public CustomersController(ICustomerService customerService, IValueObjectService valueObjectService, IProductService productService)
        {
            _customerService = customerService;
            _valueObjectService = valueObjectService;
            _productService = productService;
        }

        public async Task<ActionResult> Index()
        {
            var customerDto = await _customerService.GetCustomersAsync();
            return View(customerDto);
        }

        public async Task<ActionResult> Details(int id)
        {
            var customerDto = await _customerService.FindCustomerByIdAsync(id);
            var productsDto = await _productService.ProductsPurchasedByCustomerAsync(id);
            customerDto.ProductsPurchased = productsDto;
            if (customerDto == null) return RedirectToAction(nameof(Index));
            return View(customerDto);
        }

        public ActionResult Create()
        {
            var customerDto = new CustomerDTO();
            return View(customerDto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(CustomerDTO customerDto)
        {
            var documentExists = await _customerService.CheckIfDocumentExists(customerDto.Document);
            
            if (documentExists)
            {
                ModelState.AddModelError("Document", "This document already exists");
                return View(customerDto);
            }

            if (!ModelState.IsValid) return View(customerDto);

            await _customerService.AddCustomerAsync(customerDto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<ActionResult> Edit(int id)
        {
            var customerDto = await _customerService.FindCustomerByIdAsync(id);
            if (customerDto != null)
                return View(customerDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(CustomerDTO customerDto)
        {
            var oldCustomer = await _customerService.FindCustomerByIdAsync(customerDto.Id.Value);
            if (customerDto.Id != oldCustomer.Id && oldCustomer.Id != 0)
            {
                ModelState.AddModelError("Document", "This document already exists");
                return View(customerDto);
            }


            customerDto.IsLegalPerson = oldCustomer.IsLegalPerson;
            await _customerService.UpdateCustomerAsync(customerDto);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task Delete(int id)
        {
            await _customerService.RemoveCustomerByIdAsync(id);
        }
    }
}
