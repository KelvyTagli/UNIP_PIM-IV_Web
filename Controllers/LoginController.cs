using Azure.Messaging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PIM_IV_Web.Models;

namespace PIM_IV_Web.Controllers
{
    public class LoginController : Controller
	{
        private readonly DesktopContext _dbContext;

        public LoginController(DesktopContext db)
        {
            _dbContext = db;
        }

		public IActionResult Index()
		{
            return View();
		}

        public Usuario BuscarLogin(string? email)
        {
            return _dbContext.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }

        [HttpPost]
        public IActionResult Entrar(Usuario Usuarios)
        {
			try
			{
                if (ModelState.IsValid)
                {
                    Usuario user = BuscarLogin(Usuarios.Email);
                    if(user != null)
                    {
                        if(Usuarios.ValidatePassword(Usuarios.Senha))
                        {
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
