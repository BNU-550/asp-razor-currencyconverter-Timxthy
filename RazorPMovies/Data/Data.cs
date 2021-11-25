using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPMovies.Models;

namespace RazorPMovies
{
    public class Data : DbContext
    {
        public Data (DbContextOptions<Data> options)
            : base(options)
        {
        }

        public DbSet<RazorPMovies.Models.Movies> Movies { get; set; }
    }
}
