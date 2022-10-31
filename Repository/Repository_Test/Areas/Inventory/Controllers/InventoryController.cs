using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository_Test.Areas.Employees.Models;
using Repository_Test.Areas.Inventory.Data.Entity;
using Repository_Test.Areas.Inventory.Models;
using Repository_Test.Service.Interface;

namespace Repository_Test.Areas.Inventory.Controllers
{
    [Area("Inventory")]
    public class InventoryController : Controller
    {
        public readonly IInventory inventory;
        public InventoryController(IInventory inventory)
        {
            this.inventory = inventory;
        }

        // GET: 
        public async Task<IActionResult> Index()
        {
            InventoryViewModels model = new InventoryViewModels
            {
                products = await inventory.GetProduct()
            };
            return View(model);
        }

        // POST:
        [HttpPost]
        public async Task<IActionResult> Index([FromForm] InventoryViewModels model)
        {
            Product data = new Product
            {
                Id = model.productId,
                productCode = model.productCode,
                productName = model.productName,
            };

            await inventory.SaveProduct(data);

            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int Id)
        {
            await inventory.DeleteProductById(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}