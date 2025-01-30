using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.User
{
	public class UserDelete
	{
		[DisplayName("First Name")]
		public string First_Name { get; set; }

		[DisplayName("Last_Name")]
		public string Last_Name { get; set; }

		[EmailAddress]// Permet l'envoi d'un lien confirmation
		public string Email { get; set; }
	}
}
