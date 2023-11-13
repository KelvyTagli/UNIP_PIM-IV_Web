using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PIM_IV_Web.Models;
using System.Data;
using System.Diagnostics;
using System.Web.Helpers;

namespace PIM_IV_Web.Controllers
{
    public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		private readonly DesktopContext _dbContext;

		public HomeController(ILogger<HomeController> logger , DesktopContext dbContext)
		{
			_logger = logger;
			_dbContext = dbContext;
		}
        public Funcionario FuncionarioID(int ID)
        {
            return _dbContext.Funcionarios.FirstOrDefault(info => info.UsuarioId == ID);
        }

        public Holerite holeriteID(int Id)
        {
            return _dbContext.Holerites.FirstOrDefault(info => info.FuncionarioId == Id);
        }

        public IActionResult View(int Id)
        {
            var dados = holeriteID(Id);
            return View(dados);
        }

        public IActionResult Index()
		{
            string SessionUser = HttpContext.Session.GetString("LoggedUserSession");

            if (string.IsNullOrEmpty(SessionUser)) return null;

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(SessionUser);

            var info = FuncionarioID(usuario.UsuarioId);
            View(info.FuncionarioId);

            return View();
		}
	}
}