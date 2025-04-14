using AcunmedyaAkademi2.Controllers;
using AcunmedyaAkademiPortfolio.Controllers;
using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class LoginController : Controller
    {
        DbAcunMedyaAkademi1Entities1 context = new DbAcunMedyaAkademi1Entities1();

        public class Admin
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var user = context.TblAdmin.FirstOrDefault(x => x.Username == p.Username && x.Password == p.Password);

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(user.Username, true);
                Session["userInfo"] = user.Username;
                return RedirectToAction("CategoryList", "Category");
            }

            ViewBag.ErrorMessage = "Invalid username or password.";
            return View();
        }
    }
}
