using IcsyMvc.Common;
using IcsyMvc.Helpers;
using IcsyMvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IcsyMvc.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("Contact")]
        public ActionResult Contact()
        {
            ContactFormModel vm = new ContactFormModel();
            vm.Page = "Contact";
            return View(vm);
        }
        [HttpPost]
        public ActionResult Contact(ContactFormModel cfm)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    ContactEmail email = new ContactEmail()
                    {
                        FirstName = cfm.FromFirstName,
                        LastName = cfm.FromLastName,
                        EmailFrom = cfm.FromEmail,
                        EmailTo = ConfigurationManager.AppSettings["EmailTo"],
                        SmtpFrom = ConfigurationManager.AppSettings["SmtpFrom"],
                        Subject = cfm.Subject,
                        Message = cfm.Message
                    };
                    email.Send();

                    return RedirectToAction("Index");
                }
            }
            catch (RulesException ex)
            {
                this.ModelState.AddRuleErrors(ex);
            }
            return View(cfm);
        }

        [Route("Partner")]
        public ActionResult Partner()
        {
            return View();
        }

        [Route("Member")]
        public ActionResult Member()
        {
            ContactFormModel vm = new ContactFormModel();
            vm.Page = "Member";
            return View("Member", vm);
        }
        [HttpPost]
        public ActionResult Member(ContactFormModel cfm)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    ContactEmail email = new ContactEmail()
                    {
                        FirstName = cfm.FromFirstName,
                        LastName = cfm.FromLastName,
                        EmailFrom = cfm.FromEmail,
                        EmailTo = ConfigurationManager.AppSettings["EmailTo"],
                        SmtpFrom = ConfigurationManager.AppSettings["SmtpFrom"],
                        Subject = cfm.Subject,
                        Message = cfm.Message,
                        ProgramInterest = cfm.Program,
                        Age = cfm.Age.Value
                    };
                    email.Send();

                    return RedirectToAction("Index");
                }
            }
            catch (RulesException ex)
            {
                this.ModelState.AddRuleErrors(ex);
            }
            return View(cfm);
        }
    }
}