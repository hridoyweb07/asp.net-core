using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence.Models
{
    public class ContactModel
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public int? CountryID { get; set; }
        public DateTime? DOB { get; set; }
        public IFormFile Photo { get; set; }
    }
}
