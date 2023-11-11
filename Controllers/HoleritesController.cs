using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PIM_IV_Web.Models;
using System.Drawing;

namespace PIM_IV_Web.Controllers
{
	public class HoleritesController : Controller
	{
		private readonly DesktopContext _dbContext;

		public HoleritesController(DesktopContext dbContext)
		{
			_dbContext=dbContext;
		}

		public Funcionario FuncionarioID(int ID)
		{
			return _dbContext.Funcionarios.FirstOrDefault(info => info.UsuarioId == ID);
		}

		public Holerite holeriteID(int ID)
		{
			return _dbContext.Holerites.FirstOrDefault(holerite => holerite.FuncionarioId == ID);
		}

		public IActionResult actionResult(int ID)
		{
			var info = FuncionarioID(ID);
			return View(info);
		}

		public IActionResult holeriteAction(int ID)
		{
			var holerite = holeriteID(ID);
			return View(holerite);
		}

		public IActionResult Index()
		{
			string SessionUser = HttpContext.Session.GetString("LoggedUserSession");

			if (string.IsNullOrEmpty(SessionUser)) return null;

			Usuario usuario = JsonConvert.DeserializeObject<Usuario>(SessionUser);

			var info = FuncionarioID(usuario.UsuarioId);

			actionResult(usuario.UsuarioId);
			holeriteAction(info.FuncionarioId);

			return View();
		}
	}
}
