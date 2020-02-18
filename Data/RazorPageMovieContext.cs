using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPageMovie.Models
{
    public class RazorPageMovieContext : DbContext
    {
        public RazorPageMovieContext (DbContextOptions<RazorPageMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageMovie.Models.Movie> Movie { get; set; }
    }
}
