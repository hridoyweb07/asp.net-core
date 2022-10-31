using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Areas.Inventory.Data.Entity
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string productCode { get; set; }
        public string productName { get; set; }
    }
}
