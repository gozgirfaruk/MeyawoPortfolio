using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
namespace MeyawoPortfolio.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult Index()
        {
            var mesaj = db.TBLCONTACT.ToList();
            return View(mesaj);
        }

        public ActionResult Delete(int id)
        {
            var values = db.TBLCONTACT.Find(id);
            db.TBLCONTACT.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}