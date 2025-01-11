using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        DbAcunMedyaAkademi1Entities db = new DbAcunMedyaAkademi1Entities();
        public ActionResult Index()
        {

            return View();
        }
    }
}