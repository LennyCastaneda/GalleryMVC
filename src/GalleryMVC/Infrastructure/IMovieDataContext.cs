using System.Data.Entity;
using GalleryMVC.Models;

namespace GalleryMVC.Infrastructure
{
    public interface IMovieDataContext
    {
        IDbSet<CastStar> CastStar { get; set; }
        IDbSet<Movie> Movie { get; set; }
    }
}