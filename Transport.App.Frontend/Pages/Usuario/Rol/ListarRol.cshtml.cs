using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarRolModel : PageModel
    {
        private readonly IRepositorioRol _repoRol = new RepositorioRol(new Persistencia.AppRepositorios.AppContext());
        public IEnumerable<Rol> roles { get; set; }
        public void OnGet()
        {
            roles = _repoRol.GetAllRol();
        }
    }
}
