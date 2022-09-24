using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearNivelEstudioModel : PageModel
    {
        private readonly IRepositorioNivelEstudio _repoNivelEstudio = new RepositorioNivelEstudio( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public NivelEstudio NewNivelEstudio {get; set;}
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoNivelEstudio.AddNivelEstudio(NewNivelEstudio);
            return RedirectToPage("./ListarNivelEstudio");
        }
    }
}
