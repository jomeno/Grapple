﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grapple.Web.Areas.Merchant.Controllers
{
    public class HomeController : Controller
    {
        // GET: Merchant/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}