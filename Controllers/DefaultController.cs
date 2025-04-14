using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {

        DbAcunMedyaAkademi1Entities1 db = new DbAcunMedyaAkademi1Entities1();

        public PartialViewResult PartialExperience()
        {
            var values = db.TblExperience.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialSkill()
        {
            var values = db.TblSkıll.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialSidebar()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeroSection()
        {
            return PartialView();
        }


    }
}