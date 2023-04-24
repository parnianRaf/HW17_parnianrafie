using System;
namespace AppCore.Entities
{
	public class StudentContactInfo
	{
		public int StudentId { get; set; }
		public string Email { get; set; }
		public string PhoneNo { get; set; }
		public string Address { get; set; }
		public Student Student { get; set; }

	}
}

