using Microsoft.EntityFrameworkCore;
/*Created by Beig
 * DBContext class manages the connection to the database.
 * The DBSet properties for three tables inside the dbset.
 * The options comes from the program.cs file DI
 
 */
namespace BeigWeek6.Models
{
    public class HogwartsContext : DbContext
    {
        //DBContext class is derive class form the parent class called DbContext
        //include the base type:DbContext next to the class name.
        public HogwartsContext(DbContextOptions<HogwartsContext> options): base(options)
        {
            // reqires using Microsoft.EntityFrameworkCore;
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
