#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

    public class commentContext : DbContext
    {
        public commentContext (DbContextOptions<commentContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.comment> comment { get; set; }
    }
