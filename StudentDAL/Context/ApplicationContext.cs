using Microsoft.EntityFrameworkCore;
using StudentENTITIES;

namespace StudentDAL.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = ADMIN\SQLEXPRESS; database = StudentApp; 
Trusted_Connection = True; TrustServerCertificate=True; Connect Timeout = 30; MultipleActiveResultSets = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>().HasKey(x => x.Id);
            modelBuilder.Entity<Teacher>().HasKey(x => x.Id);
            modelBuilder.Entity<Lesson>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
        }
    }
}
// optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Student;Trusted_Connection=true");