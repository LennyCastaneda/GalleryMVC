using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GalleryMVC.Models
{
    public class CastStar
    {
        internal ICollection<object> Movies;

        public object CastStarId { get; internal set; }
        public object MovieId { get; internal set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }
}