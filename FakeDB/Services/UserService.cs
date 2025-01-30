using Common.Repositories;
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeDB.Services
{
	public class UserService : IUserRepository<DAL.Entities.User>
	{
		public Guid CheckPassword(string email, string password)
		{
			throw new NotImplementedException();
		}

		public void Delete(Guid id)
		{
			throw new NotImplementedException();
		}

		public User Get(Guid id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAll()
		{
			throw new NotImplementedException();
		}

		public Guid Insert(User user)
		{
			throw new NotImplementedException();
		}

		public void Update(Guid id, User user)
		{
			throw new NotImplementedException();
		}
	}
}
