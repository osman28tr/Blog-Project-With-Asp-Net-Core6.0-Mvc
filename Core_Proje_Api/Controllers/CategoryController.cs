using Core_Proje_Api.DAL.ApiContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		[HttpGet]
		public IActionResult CategoryList()
		{
			var context = new Context();
			return Ok(context.Categories.ToList());
		}
	}
}
