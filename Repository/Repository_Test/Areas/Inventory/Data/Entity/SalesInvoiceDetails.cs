using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Areas.Inventory.Data.Entity
{
    public class SalesInvoiceDetails
    {
        [Key]
        public int Id { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public int? productId { get; set; }
        public Product product { get; set; }
        public int? salesInvoiceMasterId { get; set; }
        public SalesInvoiceMaster salesInvoiceMaster { get; set; }
    }
}
