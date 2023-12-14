using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : ControllerBase
	{
		private readonly IRepository _Repository;
		public CartController(IRepository Repository)
		{
			_Repository = Repository;
		}
	}
}
