using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarTipoIdentificacionModel : PageModel
    {
        private readonly IRepositorioTipoIdentificacion _repoTipoIdentificacion = new RepositorioTipoIdentificacion( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <TipoIdentificacion> tipoIdentificaciones {get; set;}
        public void OnGet()
        {
            tipoIdentificaciones = _repoTipoIdentificacion.GetAllTipoIdentificacion();
        }

        public IActionResult OnPost(int Id)
        {
            _repoTipoIdentificacion.DeleteTipoIdentificacion(Id);
            return RedirectToAction("Get");
        }
    }
}
