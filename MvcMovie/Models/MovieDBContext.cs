using System;
using System.Data.Entity;
using System.Linq;

namespace MvcMovie.Models
{
    public class MovieDBContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
    }
}