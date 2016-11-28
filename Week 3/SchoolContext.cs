using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Week3.Models;

namespace Week3
{
    public class SchoolContext : DbContext 
    {
        public SchoolContext() : base("SchoolDB")
        {
            // Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Student> Studenten { get; set; }
        public DbSet<Country> Country { get; set; }
    }
}
