using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class TestimonialController : Controller
    {
        DbAcunMedyaAkademi1Entities1 db = new DbAcunMedyaAkademi1Entities1();

        public ActionResult TestimonialList()
        {
            var values = db.TblTestimonial.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateTestimonial(TblTestimonial testimonial)
        {
            db.TblTestimonial.Add(testimonial);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        public ActionResult DeleteTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            db.TblTestimonial.Remove(value);
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = db.TblTestimonial.Find(id);
            return View("UpdateTestimonial", value);
        }

        [HttpPost]
        public ActionResult UpdateTestimonial(TblTestimonial testimonial)
        {
            var value = db.TblTestimonial.Find(testimonial.TestimonialId);
            value.NameSurname = testimonial.NameSurname;
            value.ImageUrl = testimonial.ImageUrl;
            value.Title = testimonial.Title;
            value.CommentDetail = testimonial.CommentDetail;
            db.SaveChanges();
            return RedirectToAction("TestimonialList");
        }

    }
}