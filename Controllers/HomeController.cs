using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PIM_IV_Web.Models;
using System.Diagnostics;

namespace PIM_IV_Web.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DesktopContext _dbContext;

		public HomeController(ILogger<HomeController> logger, DesktopContext dbContext)
		{
			_logger = logger;
			_dbContext=dbContext;
		}

		public IActionResult Index()
		{
			return View();
		}
	}
}