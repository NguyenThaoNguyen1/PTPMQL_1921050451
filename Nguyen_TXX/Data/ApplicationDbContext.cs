using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Nguyen_TXX.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Nguyen_TXX.Models.Student> Student { get; set; } = default!;

        public DbSet<Nguyen_TXX.Models.EmPloyee> EmPloyee { get; set; } = default!;
    }
