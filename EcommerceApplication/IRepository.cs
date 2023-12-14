using EcommerceApplication.Models;

namespace EcommerceApplication
{
	public interface IRepository
	{
		List<User> GetUsers();
		User GetUserById(int id);
		void CreateUser(User user);
		void UpdateUser(int id, User user);
	    void DeleteUser(int id);
	}
}
