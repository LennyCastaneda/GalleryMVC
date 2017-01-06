using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GalleryMVC.Models;

namespace GalleryMVC.Controllers
{
    public class GalleryController : Controller
    {
        public ActionResult Grid()
        {
            var Movie = new Movie()
            {
                MovieTitle = "The Amazing Spiderman",
                Year = 2012,
                DescriptionHtml = "<p>After Peter Parker is bitten by a genetically altered spider, he gains newfound, spider-like powers and ventures out to solve the mystery of his parent's mysterious death.</p>",
                CastStars = new CastStar[]
                {
                    new CastStar() { Name = "Andrew Garfield", Role =  " Sprider-Man / Peter Parker" },
                    new CastStar() { Name = "Emma Stone", Role = "Emma Stone" },
                    new CastStar() { Name = "Rhys Ifans", Role = "The Lizard / Dr. Curt Connors" },
                    new CastStar() { Name = "Denis Leary", Role = "Captain Stacy" },
                    new CastStar() { Name = "Martin Sheen", Role = "Uncle Ben" },
                    new CastStar() { Name = "Sally Field", Role = "Aunt May" },
                    new CastStar() { Name = "Irrfan Khan", Role = "Rajit Ratha" },
                    new CastStar() { Name = "Campbell Scott", Role = "Rajita Ratha" },
                }
            };

            // Strongly typed view to access the model property
            return View(Movie);
        }
    }
} 