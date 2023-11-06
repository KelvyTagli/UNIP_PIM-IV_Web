using PIM_IV_Web.Models;

namespace PIM_IV_Web.Sections
{
    public interface ISection
    {
        void CreateUserSection(Usuario usuario);
        void RemoveUserSection();
        Usuario SearchUser();
    }
}
