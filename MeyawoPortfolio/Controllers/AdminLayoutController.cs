﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MeyawoPortfolio.Models;

namespace MeyawoPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: _AdminLayout
        DBMyPortfolioEntities db = new DBMyPortfolioEntities();
        public ActionResult _Layout()
        {
            return View();
        }
        public PartialViewResult _HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult _SidebarPartial()
        {
            
            return PartialView();
        }

        public PartialViewResult _ScriptsPartial()
        {
            return PartialView();
        }
    }
}