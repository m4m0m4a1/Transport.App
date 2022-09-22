using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarPersonaModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona = new RepositorioPersona( new Persistencia.AppRepositorios.AppContext() );
        private readonly IRepositorioTipoIdentificacion _repoTipoIdentificacion = new RepositorioTipoIdentificacion( new Persistencia.AppRepositorios.AppContext() );
        private readonly IRepositorioRol _repoRol = new RepositorioRol(new Persistencia.AppRepositorios.AppContext());
        private readonly IRepositorioNivelEstudio _repoNivelEstudio = new RepositorioNivelEstudio( new Persistencia.AppRepositorios.AppContext() );
        private readonly IRepositorioGenero _repoGenero = new RepositorioGenero( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <NivelEstudio> nivelEstudios {get; set;}
        public IEnumerable <Rol> roles { get; set; }
        public IEnumerable <Genero> generos {get; set;}
        public IEnumerable <TipoIdentificacion> tipoIdentificaciones {get; set;}
        [BindProperty]
        public Persona? EditPersona { get; set; }
        public IActionResult OnGet(int? Id)
        {
           tipoIdentificaciones = _repoTipoIdentificacion.GetAllTipoIdentificacion();
           generos = _repoGenero.GetAllGenero();
           roles = _repoRol.GetAllRol();
           nivelEstudios = _repoNivelEstudio.GetAllNivelEstudio();

            if (Id.HasValue)
            {
                EditPersona = _repoPersona.GetPersona(Id.Value);
            }
            else
            {
                EditPersona = new Persona();
            }
            if (EditPersona == null)
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
            _repoPersona.UpdatePersona(EditPersona);
            return RedirectToPage("./ListarPersona");
        }
    }
}
