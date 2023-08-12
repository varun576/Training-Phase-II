using Microsoft.EntityFrameworkCore;
using StudentDetailsCF.Models;

namespace StudentDetailsCF.Context
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options) 
        { 
        }

    }
}
