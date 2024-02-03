using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ProjectController : Controller
        
    {
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();

        // GET: Project
        public ActionResult Index()
        {
            var deger = db.TBLPROJECT.ToList();
            return View(deger);
        }

        public ActionResult Delete (int id)
        {
            var values = db.TBLPROJECT.Find(id);
            db.TBLPROJECT.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            //bir tablodaki tüm değerleri çekmek yerine sadece bir özelligini getirmek için kullanırız.
            List<SelectListItem> values = (from x in db.TBLCATEGORY.ToList()
                                           select new SelectListItem
                                           {
                                               Text=x.CategoryName,
                                               Value=x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }

        [HttpPost]
        public ActionResult CreateProject(TBLPROJECT p1)
        {
            db.TBLPROJECT.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            List<SelectListItem> values1 = (from x in db.TBLCATEGORY.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values1;
            var values = db.TBLPROJECT.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProject(TBLPROJECT p)
        {
            var value = db.TBLPROJECT.Find(p.ProjectID);
            value.Description = p.Description;
            value.ImageUrl = p.ImageUrl;
            value.ProjectCategory = p.ProjectCategory;
            value.ProjectUrl = p.ProjectUrl;
            value.Title = p.Title;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult GitRepo(int id)
        {
            var value = db.TBLPROJECT.Find(id);
            return RedirectToAction("Index");
        }


    }
}