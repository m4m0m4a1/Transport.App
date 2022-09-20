using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearTipoIdentificacionModel : PageModel
    {
        private readonly IRepositorioTipoIdentificacion _repoTipoIdentificacion = new RepositorioTipoIdentificacion( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public TipoIdentificacion NewTipoIdentificacion {get; set;}
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoTipoIdentificacion.AddTipoIdentificacion(NewTipoIdentificacion);
            return RedirectToPage("./ListarTipoIdentificacion");
        }
    }
}
