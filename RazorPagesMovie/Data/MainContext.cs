using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace Data
{
    public class MainContext : DbContext
    {
        public MainContext (DbContextOptions<MainContext> options)
            : base(options)
        {
        }

        public DbSet<Movie>? Movie { get; set; }
    }
}
