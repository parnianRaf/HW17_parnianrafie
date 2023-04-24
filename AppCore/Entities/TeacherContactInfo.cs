using System;
namespace AppCore.Entities
{
	public class TeacherContactInfo
	{
        public int TeacherId { get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public Teacher Teacher { get; set; }
    }
}

