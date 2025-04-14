using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class EducationController : Controller
    {
        DbAcunMedyaAkademi1Entities1 db = new DbAcunMedyaAkademi1Entities1();
        public ActionResult EducationList()
        {
            var values = db.TblEducation.ToList(); 
            return View(values); 
        }

        [HttpGet]   
        public ActionResult CreateEducation()
        {
            return View();
        }

        [HttpPost]   
        public ActionResult CreateEducation(TblEducation category)
        {
            db.TblEducation.Add(category);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        
        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            db.TblEducation.Remove(value);
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducation.Find(id);
            return View("UpdateEducation", value);
        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation edu)
        {
            var value = db.TblEducation.Find(edu.EducationId);
            value.Title = edu.Title;
            value.Description = edu.Description;
            value.SubTitle = edu.SubTitle;
            db.SaveChanges();
            return RedirectToAction("EducationList");
        }
    }
}