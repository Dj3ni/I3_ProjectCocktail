using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.Auth
{
	public class AuthLoginForm
	{
		[Required(ErrorMessage = "Email field is compulsory")]
		[DisplayName("Email: ")]
		[EmailAddress]
		public string Email { get; set; }


		[Required(ErrorMessage = "Password field is compulsory")]
		[MaxLength(32, ErrorMessage = "Password field has a max size of 64 characters")]
		[MinLength(8, ErrorMessage = "Password field has a min size of 8 characters")]
		[RegularExpression(@"^.*(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\-_+=\.()\[\]!?*{}]).*", ErrorMessage = "Password field must contains min 1Capital letter,1 Lower letter, 1 number and 1 symbol")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
