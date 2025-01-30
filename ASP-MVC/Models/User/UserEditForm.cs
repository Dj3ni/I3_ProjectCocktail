using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.User
{
	public class UserEditForm
	{
		[Required(ErrorMessage = "Firstname field is compulsory")]
		[DisplayName("Firstname: ")]
		[MaxLength(64, ErrorMessage = "Firstname field has a max size of 64 characters")]
		[MinLength(2, ErrorMessage = "Firstname field has a min size of 2 characters")]
		public string First_Name { get; set; }


		[Required(ErrorMessage = "Lastname field is compulsory")]
		[DisplayName("Lastname: ")]
		[MaxLength(64, ErrorMessage = "Lastname field has a max size of 64 characters")]
		[MinLength(2, ErrorMessage = "Lastname field has a min size of 2 characters")]
		public string Last_Name { get; set; }


		[Required(ErrorMessage = "Email field is compulsory")]
		[DisplayName("Email: ")]
		[EmailAddress]
		public string Email { get; set; }
	}
}
