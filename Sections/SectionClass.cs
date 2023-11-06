using Newtonsoft.Json;
using PIM_IV_Web.Models;
using System.Text.Json.Serialization;

namespace PIM_IV_Web.Sections
{
    public class SectionClass : ISection
    {
        private readonly IHttpContextAccessor _Httpcontext;

        public SectionClass(IHttpContextAccessor httpContext)
        {
            _Httpcontext = httpContext;
        }

        public void CreateUserSection(Usuario usuario)
        {
            string Value = JsonConvert.SerializeObject(usuario);
#pragma warning disable CS8602 // Desreferência de uma referência possivelmente nula.
            _Httpcontext.HttpContext.Session.SetString("LoggedUserSession",Value);
#pragma warning restore CS8602 // Desreferência de uma referência possivelmente nula.
        }

        public void RemoveUserSection()
        {
            _Httpcontext.HttpContext.Session.Remove("LoggedUserSession");
        }

        public Usuario SearchUser()
        {
            string SectionUser = _Httpcontext.HttpContext.Session.GetString("LoggedUserSession");
            if (string.IsNullOrEmpty(SectionUser)) return null;

            return JsonConvert.DeserializeObject<Usuario>(SectionUser);
        }
    }
}
