using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = db.TBLSERVİCE.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateService (TBLSERVİCE p1)
        {
            var values = db.TBLSERVİCE.Add(p1);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var values = db.TBLSERVİCE.Find(id);
            db.TBLSERVİCE.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.TBLSERVİCE.Find(id);
            return View(value);

        }

        [HttpPost]
        public ActionResult UpdateService(TBLSERVİCE p)
        {
            var values = db.TBLSERVİCE.Find(p.ServiceID);
            values.Title = p.Title;
            values.Description = p.Description;
            values.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}