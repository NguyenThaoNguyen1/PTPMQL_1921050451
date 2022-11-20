using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Upload.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Upload.Models.Employee> Employee { get; set; } = default!;

        public DbSet<Upload.Models.Faculty> Faculty { get; set; } = default!;
    }
