using System;
namespace AppCore.Entities
{
	public class Course
	{
		public int Id { get; set; }
		public string CourseNo { get; set; }
		public string CourseName { get; set; }
		public Teacher CourseTeacher { get; set; }
		public int TeacherId { get; set; }
        public List<StudentCourse> StudentCourses { get; set; }
    }
}

