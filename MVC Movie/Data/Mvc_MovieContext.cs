using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace Mvc_Movie.Data
{
    public class Mvc_MovieContext : DbContext
    {
        public Mvc_MovieContext (DbContextOptions<Mvc_MovieContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
