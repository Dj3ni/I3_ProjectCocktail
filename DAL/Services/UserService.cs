using DAL.Entities;
using DAL.Mappers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
	public class UserService
	{
		private const string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=WAD24-DemoASP-DB;Integrated Security=True;Connect Timeout=60;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

		//Searching the user in the list
		public IEnumerable<User> Get()
		{
			//Connection to DB
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				//Command
				using (SqlCommand command = connection.CreateCommand())
				{
					//Get with stocked procedure for the Sql command
					command.CommandText = "SP_User_GetAllActive";
					command.CommandType = System.Data.CommandType.StoredProcedure;
					connection.Open();
					// multiple infos so we use DataReader
					using (SqlDataReader reader = command.ExecuteReader())
					{
						while (reader.Read())
						{
							//We use the mapper we created
							yield return reader.ToUser();
						}
					}
				}
			}
		}

		//Searching the User By the Id
		public User Get(Guid user_id)
		{
			using (SqlConnection connection = new SqlConnection(ConnectionString))
			{
				using (SqlCommand command = connection.CreateCommand())
				{
					command.CommandText = "SP_User_GetById";
					command.CommandType = System.Data.CommandType.StoredProcedure;
					command.Parameters.AddWithValue(nameof(user_id), user_id);
					connection.Open();
					using (SqlDataReader reader = command.ExecuteReader())
					{
						if (reader.Read())
						{
							return reader.ToUser();
						}
						else
						{
							throw new ArgumentOutOfRangeException(nameof(user_id));
						}
					}

				}
			}
		}
	}
}
