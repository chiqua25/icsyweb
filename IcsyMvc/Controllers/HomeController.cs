using IcsyMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcsyMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        
        public ActionResult Contact()
        {
            ContactFormModel vm = new ContactFormModel();
            return View(vm);
        }
        [HttpPost]
        public ActionResult Contact(ContactFormModel cfm)
        {
            if(ModelState.IsValid)
            {

            }
            return View(cfm);
        }
        public ActionResult Partner()
        {
            return View();
        }

        public ActionResult Member()
        {
            return View();
        }
    }
}