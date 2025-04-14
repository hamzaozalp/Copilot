using AcunmedyaAkademiPortfolio.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        DbAcunMedyaAkademi1Entities1 db = new DbAcunMedyaAkademi1Entities1();
        public ActionResult SkillList() 
        {
            var values = db.TblSkıll.ToList();
            return View(values);
        }
        

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateSkill(TblSkıll skill) 
        {
            db.TblSkıll.Add(skill); 
            db.SaveChanges(); 
            return RedirectToAction("SkillList"); 
        }

        
                                  
        public ActionResult DeleteSkill(int id)
        {
            var skillValue = db.TblSkıll.Find(id);
            db.TblSkıll.Remove(skillValue);
            db.SaveChanges(); 
            return RedirectToAction("SkillList");
        }

        

        
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            
            var skillValue = db.TblSkıll.Find(id); 
            return View(skillValue); 
        }
        [HttpPost]
        public ActionResult UpdateSkill(TblSkıll skill)
        {
          
            var skillValue = db.TblSkıll.Find(skill.SkıllId); 
            skillValue.SkıllTable = skill.SkıllTable; 
            skillValue.SkıllValue = skill.SkıllValue;
            db.SaveChanges(); 
            return RedirectToAction("SkillList"); 
        }
    }
    
    
    
}