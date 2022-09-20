using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarNivelEstudioModel : PageModel
    {
        private readonly IRepositorioNivelEstudio _repoNivelEstudio = new RepositorioNivelEstudio(new Persistencia.AppRepositorios.AppContext());
        [BindProperty]
        public NivelEstudio? EditNivelEstudio { get; set; }
        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                EditNivelEstudio = _repoNivelEstudio.GetNivelEstudio(Id.Value);
            }
            else
            {
                EditNivelEstudio = new NivelEstudio();
            }
            if (EditNivelEstudio == null)
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
            _repoNivelEstudio.UpdateNivelEstudio(EditNivelEstudio);
            return RedirectToPage("./ListarNivelEstudio");
        }
    }
}
