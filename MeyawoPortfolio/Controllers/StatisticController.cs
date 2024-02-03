using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult Index()
        {
            //Aggerate --> Sum Count Avg Min Max
            ViewBag.categoryCount = db.TBLCATEGORY.Count();
            ViewBag.projectCount = db.TBLPROJECT.Count();
            ViewBag.messageCount = db.TBLCONTACT.Count();
            ViewBag.lastProjectName = db.LASTPROJECTNAME().FirstOrDefault();
            ViewBag.isReadMessageCount = db.TBLCONTACT.Where(x => x.IsRead == false).Count();
            ViewBag.referansSay = db.TBLTESTIMONIAL.Count();
            ViewBag.deneme = db.TBLSOCIALMEDIA.Count(); 
            return View();
        }
    }
}