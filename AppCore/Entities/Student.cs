using System;
namespace AppCore.Entities
{
	public class Student
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string StudentNo { get; set; }
		public string EntryYear { get; set; }
		public int Age { get; set; }
		public StudentContactInfo ContactInfo { get; set; }
		public List<StudentCourse> StudentCourses { get; set; }

	}
}

