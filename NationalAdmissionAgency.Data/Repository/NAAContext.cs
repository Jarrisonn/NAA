using NationalAdmissionAgency.Data.Models.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalAdmissionAgency.Data.Repository
{
    public class NAAContext : DbContext
    {
        public NAAContext() : base("NAAContext")
        {
            Database.SetInitializer(new NAAInitialiser());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Application> Applications { get; set; }

        public DbSet<University> Universities { get; set; }

       
    }
}
