using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApplication.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IRepository _Repository;
		public ProductController(IRepository Repository)
		{
			_Repository = Repository;
		}
	}
}
