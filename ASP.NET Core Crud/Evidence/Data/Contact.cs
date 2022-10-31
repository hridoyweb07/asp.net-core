using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence.Data
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int? CountryID { get; set; }
        public DateTime? DOB { get; set; }
        public string Photo { get; set; }
    }
}
