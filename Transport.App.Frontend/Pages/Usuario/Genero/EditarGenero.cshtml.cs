using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarGeneroModel : PageModel
    {
        private readonly IRepositorioGenero _repoGenero = new RepositorioGenero( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public Genero? EditGenero {get; set;}
        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                EditGenero = _repoGenero.GetGenero(Id.Value);
            }
            else
            {
                EditGenero = new Genero();
            }
            if (EditGenero == null)
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
            _repoGenero.UpdateGenero(EditGenero);
            return RedirectToPage("./ListarGenero");
        }
    }
}
