﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GalleryMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHtml { get; set; }
        public CastStar[] CastStars { get; set; }
    }
}