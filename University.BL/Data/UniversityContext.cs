using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.BL.Models;

namespace University.BL.Data
{
    public class UniversityContext : DbContext
    {
        //Conexión base de datos por medio del servidor (Web.config)
        public UniversityContext() : base("UniversityContext")
        {
            
        }

        public DbSet<Course> Coruses { get; set; }
        public DbSet<Student> Studetns { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public static UniversityContext Create()
        {
            return new UniversityContext();
        }
    }
}
