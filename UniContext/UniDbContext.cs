using AppCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace UniContext;
public class UniDbContext:DbContext
{
    public UniDbContext(DbContextOptions<UniDbContext> options):base(options) { }
   


    DbSet<Course> Course { get; set; }
    DbSet<Student> Student { get; set; }
    DbSet<StudentContactInfo> StudentContactInfo { get; set; }
    DbSet<StudentCourse> StudentCourse { get; set; }
    DbSet<Teacher> Teacher { get; set; }
    DbSet<TeacherContactInfo> TeacherContactInfo { get; set; }
}

