using BlazorEcommerce.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Services.ProductService;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly DataContext _context;
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpGet]
		public async Task<ServiceResponse<List<Product>>> GetProducts()
		{
			var result = await _productService.GetProductsAsync();
			return result;
		}
	}
}

