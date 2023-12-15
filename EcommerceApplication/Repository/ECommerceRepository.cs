using EcommerceApplication.Data;
using EcommerceApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Repository
{
	public class ECommerceRepository : IRepository
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
		public List<Product> GetProducts()
		{
			return databaseContext.Products.ToList();
		}

		public Product GetProductById(int id)
		{
			return databaseContext.Products.FirstOrDefault(u => u.Id == id);
		}

		public void CreateProduct(Product product)
		{
			databaseContext.Products.Add(product);
			databaseContext.SaveChanges();
		}
		public void UpdateProduct(int id, Product updatedProduct)
		{
			Product existingProduct = databaseContext.Products.FirstOrDefault(s => s.Id == id);
			if (existingProduct != null)
			{
				existingProduct.Name = updatedProduct.Name;
				existingProduct.Description = updatedProduct.Description;
				existingProduct.Price = updatedProduct.Price;
				databaseContext.SaveChanges();
			}

		}

		public void DeleteProduct(int id)
		{
			Product product = databaseContext.Products.FirstOrDefault(s => s.Id == id);

			databaseContext.Products.Remove(product);
			databaseContext.SaveChanges();
		}
		public List<Cart> GetCarts()
		{
			return databaseContext.Carts.ToList();
		}

		public Cart GetCartById(int id)
		{
			return databaseContext.Carts.FirstOrDefault(u => u.Id == id);
		}

		public void CreateCart(Cart carts)
		{
			databaseContext.Carts.Add(carts);
			databaseContext.SaveChanges();
		}
		public void UpdateCart(int id, Cart updatedCart)
		{
			Cart existingCart = databaseContext.Carts.FirstOrDefault(s => s.Id == id);
			if (existingCart != null)
			{
				existingCart.UserId = updatedCart.UserId;
				databaseContext.SaveChanges();
			}

		}

		public void DeleteCart(int id)
		{
			Cart cart = databaseContext.Carts.FirstOrDefault(s => s.Id == id);

			databaseContext.Carts.Remove(cart);
			databaseContext.SaveChanges();
		}

	}
}