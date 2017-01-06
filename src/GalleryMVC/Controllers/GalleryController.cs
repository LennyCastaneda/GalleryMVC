using System;
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
            ViewBag.MovieTitle = "The Amazing Spiderman (2012)";
            ViewBag.Description = "After Peter Parker is bitten by a genetically altered spider, he gains newfound, spider-like powers and ventures out to solve the mystery of his parent's mysterious death.";
            ViewBag.CastStars = new string[]
            {
                "Andrew Garfield: Sprider-Man / Peter Parker",
                "Emma Stone: Gwen Stacy",
                "Rhys Ifans: The Lizard / Dr. Curt Connors",
                "Denis Leary: Captain Stacy",
                "Martin Sheen: Uncle Ben",
                "Sally Field: Aunt May",
                "Irrfan Khan: Rajit Ratha",
                "Campbell Scott: Rajita Ratha",
                "Embeth Davidtz: Mary Parker",
                "Chris Zylka: Flash Thompson",
                "Max Charles: Peter Parker (Age 4)",
                "C. Thomas Howell: Jack's Father"
            };

            return View();
        }
    }
} 