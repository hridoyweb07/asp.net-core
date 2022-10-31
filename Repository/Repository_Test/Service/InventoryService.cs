using Microsoft.EntityFrameworkCore;
using Repository_Test.ApplicationDbContext;
using Repository_Test.Areas.Inventory.Data.Entity;
using Repository_Test.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Service
{
    public class InventoryService : IInventory
    {
        private readonly AppDbContext _context;

        public InventoryService(AppDbContext context)
        {
            _context = context;
        }


        //Product Info

        public async Task<int> SaveProduct(Product products)
        {
            if (products.Id != 0)
                _context.products.Update(products);
            else
                _context.products.Add(products);

             await _context.SaveChangesAsync();
            return products.Id;
        }

        public async Task<IEnumerable<Product>> GetProduct()
        {
            return await _context.products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.products.FindAsync(id);
        }

        public async Task<bool> DeleteProductById(int id)
        {
            _context.products.Remove(_context.products.Find(id));
            return 1 == await _context.SaveChangesAsync();
        }
    }
}
