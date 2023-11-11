using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using PIM_IV_Web.Models;

namespace PIM_IV_Web.ViewComponents
{
    public class Menu : ViewComponent
    {
        private readonly DesktopContext _dbContext;

        public Menu (DesktopContext desktop)
        {
            _dbContext = desktop;
        }

        public Funcionario FuncionarioID(int ID)
        {
            return _dbContext.Funcionarios.FirstOrDefault(info => info.UsuarioId == ID);
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string SessionUser = HttpContext.Session.GetString("LoggedUserSession");

            if (string.IsNullOrEmpty(SessionUser)) return null;

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(SessionUser);

            var dados = FuncionarioID(usuario.UsuarioId);

            return View(dados);
        }
    }
}
