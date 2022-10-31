using Evidence.Data;
using Evidence.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Evidence.Controllers
{
    public class ContactController : Controller
    {
        SMS_DB _db = null;

        public ContactController(SMS_DB db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult SPA()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetCountry()
        {
            var data = _db.Country.OrderBy(x => x.CountryName).ToList();
            return Json(data);
        }

        [HttpGet]
        public IActionResult GetContact()
        {
            var data = (from o in _db.Contact
                        join c in _db.Country on o.CountryID equals c.CountryID
                        select new
                        {
                            o.ContactID,
                            o.ContactName,
                            o.Gender,
                            o.DOB,
                            c.CountryName,
                            o.Photo
                        }).ToList();
            return Json(data);
        }

        [HttpPost]
        public IActionResult Insert([FromForm] ContactModel model)
        {
            object res = null;
            var oContact = _db.Contact.Where(x => x.ContactID == model.ContactID).FirstOrDefault();
            if(oContact == null)
            {
                #region file
                string fileName = "";
                if(model.Photo != null)
                {
                    string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/photo");
                    if(!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    FileInfo fileInfo = new FileInfo(model.Photo.FileName);
                    string newFileName = DateTime.Now.ToString("yyyyMMddHHmmss");
                    fileName = newFileName + fileInfo.Extension;
                    string fileNameWithPath = Path.Combine(path, fileName);
                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        model.Photo.CopyTo(stream);
                    }
                }
                #endregion
                oContact = new Contact();
                oContact.ContactName = model.ContactName;
                oContact.Gender = model.Gender;
                oContact.Age = model.Age;
                oContact.CountryID = model.CountryID;
                oContact.DOB = model.DOB;
                oContact.Photo = fileName;
                _db.Add(oContact);
                _db.SaveChanges();
                res = new
                {
                    resstate = true
                };
            }
            return Json(res);
        }
    }
}
