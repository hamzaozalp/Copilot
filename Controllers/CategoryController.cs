using AcunmedyaAkademiPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunMedyaAkademiPortfolyo.Controllers
{
    public class CategoryController : Controller
    {
        DbAcunMedyaAkademi1Entities1 db = new DbAcunMedyaAkademi1Entities1();

        // GET: Category
        public ActionResult CategoryList()
        {
            var values = db.TblCategories.ToList(); // to list = Select * from
            return View(values);     //return view gözükürken değeleri de beraberinde getirsin
        }

        [HttpGet]   //sayfa yüklendiğinde
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]   //sayfa yüklendiğinde
        public ActionResult CreateCategory(TblCategories tblCategory)
        {
            db.TblCategories.Add(tblCategory);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        //silme işlemi için bir attribute gerekmiyor sadece id'yi alıp silmek yeterli
        public ActionResult DeleteCategory(int id)
        {
            var value = db.TblCategories.Find(id);
            db.TblCategories.Remove(value);
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }

        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var value = db.TblCategories.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateCategory(TblCategories categoryParametry)
        {
            var value = db.TblCategories.Find(categoryParametry.CategoryId);
            value.CategoryName = categoryParametry.CategoryName;
            db.SaveChanges();
            return RedirectToAction("CategoryList");
        }
    }
}