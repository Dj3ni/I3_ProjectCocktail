using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//We can use the using with aliases to avoid confusion between objects with the same name
// using BLL.Entities;
//using D = DAL.Entities;

namespace BLL.Mappers
{
	internal static class Mapper
	{
		//We will convert the DAL object to BLL object
		public static BLL.Entities.User ToBLL(this DAL.Entities.User user)
		{
			if(user == null) throw new ArgumentNullException(nameof(user));
			return new BLL.Entities.User(
					user.User_Id,
					user.First_Name,
					user.Last_Name,
					user.Email,
					user.Password,
					user.CreatedAt,
					user.DisabledAt);
		}

		//Function to convert object BLL yo Dal Object
		public static DAL.Entities.User ToDAL(this BLL.Entities.User user)
		{
			if (user == null) throw new ArgumentNullException(nameof(user));

			return new DAL.Entities.User()
			{
				User_Id = user.User_Id,
				First_Name = user.First_Name,
				Last_Name = user.Last_Name,
				Password = user.Password,
				Email = user.Email,
				CreatedAt = user.CreatedAt,
				// Disabled at is private we cannot change it, so we use the bool IsDisabled
				DisabledAt = (user.IsDisabled) ? null: new DateTime()
			};
		}
	}
}
