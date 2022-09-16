using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearPersonaModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona = new RepositorioPersona( new Persistencia.AppRepositorios.AppContext() );
        private readonly IRepositorioTipoIdentificacion _repoTipoIdentificacion = new RepositorioTipoIdentificacion( new Persistencia.AppRepositorios.AppContext() );
        private readonly IRepositorioRol _repoRol = new RepositorioRol(new Persistencia.AppRepositorios.AppContext());
        private readonly IRepositorioNivelEstudio _repoNivelEstudio = new RepositorioNivelEstudio( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <NivelEstudio> nivelEstudios {get; set;}
        public IEnumerable<Rol> roles { get; set; }
        private readonly IRepositorioGenero _repoGenero = new RepositorioGenero( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <Genero> generos {get; set;}
        public IEnumerable <TipoIdentificacion> tipoIdentificaciones {get; set;}
        public Persona personaEnviar {get; set;}
        public void OnGet()
        {
           tipoIdentificaciones = _repoTipoIdentificacion.GetAllTipoIdentificacion();
           generos = _repoGenero.GetAllGenero();
           roles = _repoRol.GetAllRol();
           nivelEstudios = _repoNivelEstudio.GetAllNivelEstudio();
        }
        public void OnPost()
        {
            _repoPersona.AddPersona(personaEnviar);
            //Redirect("./ListarPersona");
        }
    }
}
