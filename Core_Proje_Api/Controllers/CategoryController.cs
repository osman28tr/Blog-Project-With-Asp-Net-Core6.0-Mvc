﻿using Core_Proje_Api.DAL.ApiContext;
using Core_Proje_Api.DAL.Entity;
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
			using var context = new Context();
			return Ok(context.Categories.ToList());
		}
		[HttpGet("id")]
		public IActionResult GetCategoryById(int id)
		{
			using var context = new Context();
			var categoryValue = context.Categories.Find(id);
			if (categoryValue==null)
			{
				return NotFound();
			}
			else
			{
				return Ok(categoryValue);
			}
		}
		[HttpPost]
		public IActionResult CategoryAdd(Category category)
		{
			using var context = new Context();
			context.Add(category);
			context.SaveChanges();
			return Created("", category);
		}
	}
}
