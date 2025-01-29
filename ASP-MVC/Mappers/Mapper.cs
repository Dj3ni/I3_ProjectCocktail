using ASP_MVC.Models.User;

namespace ASP_MVC.Mappers
{
	internal static class Mapper
	{
		public static UserListItem ToListItem(this BLL.Entities.User user)
		{
			if(user == null) throw new ArgumentNullException(nameof(user));
			return new UserListItem()
			{
				User_Id = user.User_Id,
				First_Name = user.First_Name,
				Last_Name = user.Last_Name,
			};
		}

		public static UserDetails ToDetails(this BLL.Entities.User user)
		{
			if(user == null) throw new ArgumentNullException( nameof(user));
			return new UserDetails()
			{
				User_Id = user.User_Id,
				First_Name = user.First_Name,
				Last_Name = user.Last_Name,
				Email = user.Email,
				CreatedAt = DateOnly.FromDateTime(user.CreatedAt),
			};
		}

	}
}
