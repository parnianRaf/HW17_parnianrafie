using AppCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace UniContext;
public class UniDbContext : DbContext
{

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }


    public UniDbContext(DbContextOptions<UniDbContext> options)
      : base(options)
    {
    }


    public DbSet<Course> Course { get; set; }
    public DbSet<Student> Student { get; set; }
    public DbSet<StudentContactInfo> StudentContactInfo { get; set; }
    public DbSet<StudentCourse> StudentCourse { get; set; }
    public DbSet<Teacher> Teacher { get; set; }
    public DbSet<TeacherContactInfo> TeacherContactInfo { get; set; }
}




