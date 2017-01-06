using GalleryMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GalleryMVC.Infrastructure
{
    public class MovieDataContext
    {
        public class MovieDataContext : DbContext
        {
            public MovieDataContext() : base(MarvelMovieGallery)
            {

            }

            // Get the IDSet for all the two class to tell Entiy Framework to design these 2 tables
            public IDbSet<CastStar> CastStar { get; set; }
            public IDbSet<Movie> Movie { get; set; }

            // Explicity model the relationships between these 3 entities (classes). Movie has many CastStars, CastStars has many Movies, etc.
            // Code-First Fluent API
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                // Compound Key (set up to find foreign key relationships.
                // explicitiy model compound key by selecting Assignment entity
                modelBuilder.Entity<CastStar>()
                            // Use .HasKey method with lambda expression creating a new annonimious object 
                            // (with values) containing both foreign keys (StudentId and ProjectId) that form the compound key.
                            .HasKey(c => new { c.CastStarId, c.MovieId });

                // A Project has many Assignments
                modelBuilder.Entity<CastStar>()
                            // A Project has many Assignments
                            .HasMany(p => p.Movie)
                            // An Assignment is with a required Project object
                            .WithRequired(a => a.Project)
                            // And this Assignment has a foreign key of ProjectId
                            .HasForeignKey(a => a.ProjectId);

                // A Student has many Assignments
                modelBuilder.Entity<Student>()
                            // A Student has many Assignments
                            .HasMany(p => p.Assignments)
                            // An Assignment is with a required Student object 
                            .WithRequired(a => a.Student)
                            // And this Assignment has a foreign key of StudentId
                            .HasForeignKey(a => a.StudentId);

            }
        }
}