using Repository_Test.Areas.Inventory.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Service.Interface
{
    public interface IInventory
    {
        Task<int> SaveProduct(Product product);
        Task<IEnumerable<Product>> GetProduct();
        Task<Product> GetProductById(int id);
        Task<bool> DeleteProductById(int id);
    }
}
