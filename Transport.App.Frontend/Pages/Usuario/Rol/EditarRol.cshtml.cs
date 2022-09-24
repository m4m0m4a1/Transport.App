using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarRolModel : PageModel
    {
        private readonly IRepositorioRol _repoRol = new RepositorioRol(new Persistencia.AppRepositorios.AppContext());
        [BindProperty]
        public Rol? EditRol { get; set; }
        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                EditRol = _repoRol.GetRol(Id.Value);
            }
            else
            {
                EditRol = new Rol();
            }
            if (EditRol == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repoRol.UpdateRol(EditRol);
            return RedirectToPage("./ListarRol");
        }
    }
}
