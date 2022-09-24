using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearRolModel : PageModel
    {
        private readonly IRepositorioRol _repoRol = new RepositorioRol(new Persistencia.AppRepositorios.AppContext());
        [BindProperty]
        public Rol NewRol { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoRol.AddRol(NewRol);
            return RedirectToPage("./ListarRol");
        }
    }
}
