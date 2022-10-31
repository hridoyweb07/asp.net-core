using Repository_Test.Areas.Inventory.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Areas.Inventory.Models
{
    public class InventoryViewModels
    {
        public int salesInvoiceDetailsId { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }
        public int productId { get; set; }
        public string productCode { get; set; }
        public string productName { get; set; }
        public int salesInvoiceMasterId { get; set; }


        public IEnumerable<Product> products;
        public IEnumerable<SalesInvoiceMaster> salesInvoiceMasters;
        public IEnumerable<SalesInvoiceDetails> salesInvoiceDetails;
    }
}
