using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GalleryMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string MovieTitle { get; set; }
        public int Year { get; set; }
        public string DescriptionHtml { get; set; }
        public CastStar[] CastStars { get; set; }

        public string DisplayText
        {
            get
            {
                return MovieTitle + '(' + Year + ')';
            }
        }

        // movie-name-year.jpg <- is the naming sequence.
        public string MoviePosterFileName
        {
            get
            {
                return MovieTitle.Replace(" ", "-").ToLower() + "-" + Year + ".jpg";
            }
        }
    }
             
}