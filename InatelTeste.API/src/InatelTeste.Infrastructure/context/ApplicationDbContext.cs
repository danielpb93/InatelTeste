using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InatelTeste.Domain.Entities;
using InatelTeste.Infrastructure.maps;
using Microsoft.EntityFrameworkCore;

namespace InatelTeste.Infrastructure.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<University> University { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UniversityMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}