using System;
using Microsoft.EntityFrameworkCore;
using MVCsample.Models;

namespace MVCsample.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
