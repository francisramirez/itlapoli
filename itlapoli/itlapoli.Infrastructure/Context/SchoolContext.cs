

using Microsoft.EntityFrameworkCore;
using itlapoli.Domian.Entities;

namespace itlapoli.Infrastructure.Context
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        public SchoolContext(DbContextOptions<SchoolContext> options)
              : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }
    }
}
