﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GalleryMVC.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult Grid()
        {
            return View();
        }
    }
}