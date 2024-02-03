using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TBLABOUT.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var values = db.TBLABOUT.Find(id);
            return View(values);
        }


        [HttpPost]
        public ActionResult Update(TBLABOUT p)
        {
            var velue = db.TBLABOUT.Find(p);
            velue.Title = p.Title;
            velue.Header = p.Header;
            velue.Description = p.Description;
            velue.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}