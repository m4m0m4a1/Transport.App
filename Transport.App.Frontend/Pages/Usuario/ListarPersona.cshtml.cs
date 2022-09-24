using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarPersonaModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona = new RepositorioPersona( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioTipoIdentificacion _repoTipoIdentificacion = new RepositorioTipoIdentificacion( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioRol _repoRol = new RepositorioRol(new Persistencia.AppRepositorios.AppContext());
        public readonly IRepositorioNivelEstudio _repoNivelEstudio = new RepositorioNivelEstudio( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioGenero _repoGenero = new RepositorioGenero( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <Persona> personas {get; set;}
        public void OnGet()
        {
            personas = _repoPersona.GetAllPersona();
        }

        public IActionResult OnPost(int Id)
        {
            _repoPersona.DeletePersona(Id);
            return RedirectToAction("Get");
        }
    }
}
