using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_MVC.Models.User
{
	public class UserCreateForm
	{
		[Required(ErrorMessage ="Firstname field is compulsory")]
		[DisplayName("Firstname: ")]
		[MaxLength(64,ErrorMessage ="Firstname field has a max size of 64 characters")]
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


		[Required(ErrorMessage = "Password field is compulsory")]
		[MaxLength(32, ErrorMessage = "Password field has a max size of 64 characters")]
		[MinLength(8, ErrorMessage = "Password field has a min size of 8 characters")]
		[RegularExpression(@"^.*(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\-_+=\.()\[\]!?*{}]).*", ErrorMessage ="Password field must contains min 1Capital letter,1 Lower letter, 1 number and 1 symbol")]
		[DataType(DataType.Password)]
		public string Password { get; set; }


		[Required(ErrorMessage = "Confirmation field is compulsory")]
		[Compare(nameof(Password),ErrorMessage ="Password and confirmation don't match")]
		
		public string ConfirmPassword { get; set; }


		[Required(ErrorMessage ="You have to read and agree terms to continue further")]
		[DisplayName("Agree terms")]
		public bool Consent {  get; set; }
	}
}
