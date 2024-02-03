using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;
using System.IO;


namespace MeyawoPortfolio.Controllers

{

    public class DefaultController : Controller
    {
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        // GET: Default


        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult FeaturePartial()
        {
            var values = db.TBLFUTURE.ToList();
            return PartialView(values);
        }


        public PartialViewResult AboutPartial()
        {

            var values = db.TBLABOUT.ToList();
            return PartialView(values);
        }


        public PartialViewResult ServicePartial()
        {
            var values = db.TBLSERVİCE.ToList();

            return PartialView(values);
        }

        public PartialViewResult PortfolioPartial()
        {
            var dgr = db.TBLPROJECT.ToList();
            return PartialView(dgr);
        }

        public PartialViewResult SectionPartial()
        {

            return PartialView();
        }

        public PartialViewResult TestPartial()
        {
            var values = db.TBLTESTIMONIAL.ToList();
            return PartialView(values);

        }
        [HttpGet]
        public PartialViewResult ContactPartial()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult ContactPartial(TBLCONTACT p)
        {
            var values= db.TBLCONTACT.Add(p);
            db.SaveChanges();
            return PartialView();
        }

        public PartialViewResult FooterPartial()
        {
            var dgr = db.TBLSOCIALMEDIA.ToList();
            return PartialView(dgr);
        }

       


    }
}