using Microsoft.EntityFrameworkCore;
using RepasoExamenControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoExamenControllers.Data
{
    public class Contexto : DbContext
    {

        public DbSet<Personas> Personas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SL0OFH9\SQLEXPRESS; Database= RespasoDb; Trusted_Connection = True;");
        }
    }
}
