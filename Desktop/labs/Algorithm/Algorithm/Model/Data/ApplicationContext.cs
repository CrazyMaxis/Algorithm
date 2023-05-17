using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Algorithm.Model.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> USERS { get; set; }
        public DbSet<Algorithm> ALGORITHMS { get; set; }
        public DbSet<User_Activity> USER_ACTIVITY { get; set; }
        public DbSet<Courses> COURSES { get; set; }
        public DbSet<User_Courses> USER_COURSES { get; set; }
        public DbSet<Question> QUESTIONS { get; set; }
        public DbSet<Test> TESTS { get; set; }
        public DbSet<User_Test> USER_TESTS { get; set; }

        public ApplicationContext() 
        { 

        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-P7BTVC4;Database=Algorithm_Adventure;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
