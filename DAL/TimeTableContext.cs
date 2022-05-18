using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Text.RegularExpressions;

namespace DAL
{
    public class TimeTableContext : DbContext
    {
        public TimeTableContext() : base("DbConnection")
        {
        }  

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();  
        }

        static TimeTableContext()  
        {
            Database.SetInitializer(new DataModelInitializer());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Auditory> Auditories { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teatcher> Teachers { get; set; }
    }
}
