using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarPersonaModel : PageModel
    {
        private readonly IRepositorioPersona _repoPersona = new RepositorioPersona( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <Persona> personas {get; set;}
        public void OnGet()
        {
            personas = _repoPersona.GetAllPersona();
        }
    }
}
