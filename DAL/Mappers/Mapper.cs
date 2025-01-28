using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mappers
{
	//Only class that can be internal (because no use with other projects
	internal static class Mapper
	{
		public static User ToUser(this IDataRecord record)
		{
			if (record is null) throw new ArgumentNullException(nameof(record)); //Or if(record is null) return null;
			return new User()
			{
				User_Id = (Guid)record[nameof(User.User_Id)],
				First_Name = (string)record[nameof(User.First_Name)],
				Last_Name = (string)record[nameof(User.First_Name)],
				Email = (string)record[nameof(
									User.Email)],
				Password = "********",
				DisabledAt = (record[nameof(User.DisabledAt)] is DBNull) ? null : (DateTime?)record[nameof(User.DisabledAt)],
			};
		}
	}
}
