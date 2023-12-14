using EcommerceApplication.Data;
using EcommerceApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Repository
{
	public class ECommerceRepository:IRepository
	{
		private readonly DatabaseContext databaseContext;
		public ECommerceRepository(DatabaseContext databaseContext)
		{
			this.databaseContext = databaseContext;
		}



		public List<User> GetUsers()
		{
			return databaseContext.Users.ToList();
		}

		public User GetUserById(int id)
		{
			return databaseContext.Users.FirstOrDefault(u => u.Id == id);
		}

		public void CreateUser(User user)
		{
			databaseContext.Users.Add(user);
			databaseContext.SaveChanges();
		}
		public void UpdateUser(int id, User updatedUser)
		{
			User existingUser = databaseContext.Users.FirstOrDefault(s => s.Id == id);
			if (existingUser != null)
			{
				existingUser.Username = updatedUser.Username;
				existingUser.Password = updatedUser.Password;
				existingUser.PhoneNumber = updatedUser.PhoneNumber;
				existingUser.EmailAddress = updatedUser.EmailAddress;
				databaseContext.SaveChanges();
			}

		}

		public void DeleteUser(int id)
		{
			User user = databaseContext.Users.FirstOrDefault(s => s.Id == id);
			
			databaseContext.Users.Remove(user);
			databaseContext.SaveChanges();
		}

	}
}
