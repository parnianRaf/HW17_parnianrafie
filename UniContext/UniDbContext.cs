using AppCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace UniContext;
public class UniDbContext : DbContext
{



 
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<StudentCourse>(b =>
        {
            b.HasKey(sc => new { sc.CourseId, sc.StudentId });
            b.HasOne(sc => sc.Student).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId);
            b.HasOne(sc => sc.Course).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.CourseId);
        });
        modelBuilder.Entity<TeacherContactInfo>(t =>
        {
            t.HasKey(t => t.TeacherId);
        });
        modelBuilder.Entity<StudentContactInfo>(t =>
        {
            t.HasKey(t => t.StudentId);
        });

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




