using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM_IV_Web.Models;
using PIM_IV_Web.Sections;

namespace PIM_IV_Web.Controllers
{
    public class LoginController : Controller
	{
        private readonly DesktopContext _dbContext;

        private readonly ISection _section;

        public LoginController(DesktopContext db, ISection section)
        {
            _dbContext = db;
            _section = section;
        }

		public IActionResult Index()
		{
            if (_section.SearchUser() != null) return RedirectToAction("Index", "Home");

            return View();
		}

        public Usuario BuscarLogin(string? email)
        {
#pragma warning disable CS8603 // Possível retorno de referência nula.
            return _dbContext.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
#pragma warning restore CS8603 // Possível retorno de referência nula.
        }

        public IActionResult Leave()
        {
            _section.RemoveUserSection();
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public IActionResult Entrar(Usuario ModelUsuarios)
        {
			try
			{
                if (ModelState.IsValid)
                {
                    Usuario Usuario = BuscarLogin(ModelUsuarios.Email);
                    if(Usuario != null)
                    {
                        if(Usuario.ValidatePassword(ModelUsuarios.Senha))
                        {
                            _section.CreateUserSection(Usuario);
                            return RedirectToAction("Index","Home");
                        }
                        TempData["Messagem de erro"] = $"Erro senha Incorreta";
                    }
                    TempData["Messagem de erro"] = $"Erro email Incorreto";
                }
                return View("Index");
            }
			catch(Exception erro)
			{
                TempData["Messagem de erro"] = $"Ops, não conseguimos efetuar seu login: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }
}
