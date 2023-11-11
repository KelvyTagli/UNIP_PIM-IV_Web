using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PIM_IV_Web.Models;
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

        public Holerite holeriteID(int ID)
        {
            return _dbContext.Holerites.FirstOrDefault(holerite => holerite.FuncionarioId == ID);
        }

        public IActionResult Index()
		{
            string SessionUser = HttpContext.Session.GetString("LoggedUserSession");

            if (string.IsNullOrEmpty(SessionUser)) return null;

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(SessionUser);

            var info = FuncionarioID(usuario.UsuarioId);
            var IDFuncionario = FuncionarioID(info.UsuarioId);
            var dados = holeriteID(IDFuncionario.FuncionarioId);

            return View(dados);
		}
	}
}