using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models.User
{
	public class UserListItem
	{
		[ScaffoldColumn(false)]
		public Guid User_Id { get; set; }
		public string First_Name { get; set; }
		public string Last_Name { get; set; }
	}
}
