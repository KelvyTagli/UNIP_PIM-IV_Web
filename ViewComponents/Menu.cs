using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PIM_IV_Web.Models;

namespace PIM_IV_Web.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string SessionUser = HttpContext.Session.GetString("LoggedUserSession");

            if (string.IsNullOrEmpty(SessionUser)) return null;

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(SessionUser);
            return View(usuario);
        }
    }
}
