using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FenIsleri.Entities.Concrete;

namespace FenIsleri.DataAccess.Concrete.EntityFramework
{
    public class FenIsleriContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Chiefdom> Chiefdoms { get; set; }
        public DbSet<StaffStatu> StaffStatus { get; set; }
        public DbSet<Duty> Duties { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Town> Towns { get; set; }
    }
}
