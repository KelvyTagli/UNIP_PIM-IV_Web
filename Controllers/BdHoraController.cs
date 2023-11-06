using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM_IV_Web.Models;

namespace PIM_IV_Web.Controllers
{
	public class BdHoraController : Controller
	{
		public IActionResult Index()
		{			
			return View();
		}
	}
}
