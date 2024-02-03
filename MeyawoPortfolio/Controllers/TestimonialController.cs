using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult Index()
        {
            var referans = db.TBLTESTIMONIAL.ToList();
            return View(referans);
            
        }
    }
}