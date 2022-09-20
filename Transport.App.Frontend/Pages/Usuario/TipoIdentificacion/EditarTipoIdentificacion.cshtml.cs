using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarTipoIdentificacionModel : PageModel
    {
        private readonly IRepositorioTipoIdentificacion _repoTipoIdentificacion = new RepositorioTipoIdentificacion( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public TipoIdentificacion? EditTipoIdentificacion { get; set; }
        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                EditTipoIdentificacion = _repoTipoIdentificacion.GetTipoIdentificacion(Id.Value);
            }
            else
            {
                EditTipoIdentificacion = new TipoIdentificacion();
            }
            if (EditTipoIdentificacion == null)
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
            _repoTipoIdentificacion.UpdateTipoIdentificacion(EditTipoIdentificacion);
            return RedirectToPage("./ListarTipoIdentificacion");
        }
    }
}
