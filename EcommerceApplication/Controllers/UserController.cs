using EcommerceApplication.Models;
using EcommerceApplication.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EcommerceApplication.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IRepository _Repository;
		public UserController(IRepository Repository)
		{
			_Repository = Repository;
		}

		[HttpGet]
		public IActionResult Get()
		{
			List<User> users = _Repository.GetUsers();
			if (users == null)
			{
				return NotFound();
			}
			return Ok(users);
		}

		[HttpGet("{id}")]

		public IActionResult GetById(int id)
		{
			User user = _Repository.GetUserById(id);
			if (user == null)
			{
				return NotFound();
			}
			return Ok(user);

		}

		[HttpPost]
		public IActionResult Post(User user)
		{
			_Repository.CreateUser(user);
			return Ok(user);
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, User updatedUser)
		{
			_Repository.UpdateUser(id, updatedUser);
			return Ok(updatedUser);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			_Repository.DeleteUser(id);
			return Ok();
		}



	}
}