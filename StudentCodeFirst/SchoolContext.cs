using System.Data.Entity;

namespace StudentCodeFirst
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}