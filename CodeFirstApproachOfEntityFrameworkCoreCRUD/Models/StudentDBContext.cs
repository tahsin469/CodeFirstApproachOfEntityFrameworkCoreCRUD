using Microsoft.EntityFrameworkCore;

namespace CodeFirstApproachOfEntityFrameworkCoreCRUD.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options)
        {

        }
        //DB Table Name
        public DbSet<Student> Students { get; set; }
    }
}
