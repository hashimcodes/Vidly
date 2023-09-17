using System.ComponentModel.DataAnnotations;

namespace VidlyF.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public MembershipType? MembershipType { get; set; }

		[Display(Name = "Membership Type")]
		public byte MembershipTypeId { get; set; }
	}
}
