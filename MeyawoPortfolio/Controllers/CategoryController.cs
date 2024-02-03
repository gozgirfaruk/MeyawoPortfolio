using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult Index()
        {
            var ktg = db.TBLCATEGORY.ToList();
            return View(ktg);
        }


        public ActionResult Delete(int id)
        {
            var values = db.TBLCATEGORY.Find(id);
            db.TBLCATEGORY.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var value = db.TBLCATEGORY.Find(id);

            return View(value);
        }

        [HttpPost]
        public ActionResult Update(TBLCATEGORY p1)
        {
            var values = db.TBLCATEGORY.Find(p1.CategoryID);
            values.CategoryName = p1.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(TBLCATEGORY p)
        {
            db.TBLCATEGORY.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}