using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorEcommerce.Server.Data;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly DataContext _context;

		public ProductController(DataContext context)
		{
			_context = context;
		}
		[HttpGet]
		public List<Product> GetProduct()
		{
			var products = _context.Products.ToList();
			return products;
		}
	}
}

