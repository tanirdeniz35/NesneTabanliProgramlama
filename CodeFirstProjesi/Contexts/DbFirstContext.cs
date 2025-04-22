using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstProjesi.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstProjesi.Contexts
{
    public class CodeFirstContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=CodeFirstDb;Username=postgres;Password=sapass");
        }
    }
}