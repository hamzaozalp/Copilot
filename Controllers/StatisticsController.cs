using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class StatisticsController : Controller
    {
        DbAcunMedyaAkademi1Entities1 db = new DbAcunMedyaAkademi1Entities1();
        // GET: Statistics
        public ActionResult StatisticList()
        {
            var values = db.TblStatistics.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateStatistic()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStatistic(TblStatistics statistic)
        {
            db.TblStatistics.Add(statistic);
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }

        public ActionResult DeleteStatistic(int id)
        {
            var value = db.TblStatistics.Find(id);
            db.TblStatistics.Remove(value);
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }

        [HttpGet]
        public ActionResult UpdateStatistic(int id)
        {
            var value = db.TblStatistics.Find(id);
            return View("UpdateStatistic", value);
        }

        [HttpPost]
        public ActionResult UpdateStatistic(TblStatistics statistic)
        {
            var value = db.TblStatistics.Find(statistic.StatisticId);
            value.Title = statistic.Title;
            value.Value = statistic.Value;
            db.SaveChanges();
            return RedirectToAction("StatisticList");
        }

    }
}