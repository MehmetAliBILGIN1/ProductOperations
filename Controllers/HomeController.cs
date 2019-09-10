using ProductOperations.Models.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductOperations.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Companys()
        {
            var model = db.Companys.ToList();
                return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            Models.Company company = new Models.Company();
            if (company.CompanyName == "" || company.Price == 0 || company.Result == 0)
            {
                ViewBag.Message = string.Format("Cannot Be NULL");
            }
            else { 
                company.CompanyName = form["CompanyName"].Trim();
                company.Price = Convert.ToDouble(form["Price"].Trim());
                company.Result = Convert.ToInt32(form["Result"].Trim());
                db.Companys.Add(company);
                db.SaveChanges();
            }


            return View();
        }

    }
}