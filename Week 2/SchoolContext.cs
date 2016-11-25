using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Week2.Models;

namespace Week2
{
    public class SchoolContext : DbContext 
    {
        public SchoolContext() : base()
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Student>()
            //             .HasRequired<Country>(c => c.Country)
            //             .WithMany(s => s.Students)
            //             .HasForeignKey(s => s.fkCountryID);
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; } 
        public DbSet<Country> Countries { get; set; }
    }
}
