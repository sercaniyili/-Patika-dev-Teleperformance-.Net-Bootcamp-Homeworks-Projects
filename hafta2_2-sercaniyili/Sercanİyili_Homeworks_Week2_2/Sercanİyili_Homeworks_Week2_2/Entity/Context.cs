using Microsoft.EntityFrameworkCore;

namespace Sercanİyili_Homeworks_Week2_2.Entity
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options): base(options){}


        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
       

    }
}
