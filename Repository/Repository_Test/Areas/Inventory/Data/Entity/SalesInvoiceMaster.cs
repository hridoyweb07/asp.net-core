using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Areas.Inventory.Data.Entity
{
    public class SalesInvoiceMaster
    {
        [Key]
        public int Id { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
    }
}
