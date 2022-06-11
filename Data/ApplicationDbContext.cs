using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebProgrammingMovie.Models;
using WebProgrammingMovie.Seeds;

namespace WebProgrammingMovie.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DataSeed.ActorSeed(builder);
            DataSeed.CategorySeed(builder);
            DataSeed.DirectorSeed(builder);
            DataSeed.MovieSeed(builder);
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

    }
}
