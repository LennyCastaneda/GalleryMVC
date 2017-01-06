using GalleryMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Infrastructure;

namespace GalleryMVC.Infrastructure
{
    public class MovieDataContext
    {
        public class MovieDataContext : DbContext, IMovieDataContext
        {
            private static DbCompiledModel MarvelMovieGallery;

            public MovieDataContext() : base(MarvelMovieGallery)
            {

            }

            // Get the IDSet for all the two class to tell Entiy Framework to design these 2 tables
            public IDbSet<CastStar> CastStar { get; set; }
            public IDbSet<Movie> Movie { get; set; }

            // Explicity model the relationships between these 2 entities (classes). Movie has many CastStars, CastStars has many Movies, etc.
            // Code-First Fluent API
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                // Compound Key (set up to find foreign key relationships.
                // explicitiy model compound key by selecting Assignment entity
                modelBuilder.Entity<CastStar>()
                            // Use .HasKey method with lambda expression creating a new annonimious object 
                            // (with values) containing both foreign keys (StudentId and ProjectId) that form the compound key.
                            .HasKey(c => new { c.CastStarId, c.MovieId });

                // A CastStar has many Movies
                modelBuilder.Entity<CastStar>()
                            // A CastStar has many Movies
                            .HasMany(m => m.Movies)
                            // An Movie is with a required CastStar object
                            .WithRequired(c => c.Movie)
                            // And this Movie has a foreign key of MovieId
                            .HasForeignKey(c => c.MovieId);

                // A Movie has many CastStars
                modelBuilder.Entity<Movie>()
                            // A Student has many Assignments
                            .HasMany(c => c.CastStars)
                            // And this Assignment has a foreign key of StudentId
                            .HasForeignKey(m => m.CastStarId);

            }
        }
}