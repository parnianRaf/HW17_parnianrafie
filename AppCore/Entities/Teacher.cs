using System;
namespace AppCore.Entities
{
	public class Teacher
	{
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public TeacherContactInfo ContactInfo { get; set; }
        public List<Course>? Courses { get; set; }

    }
}

