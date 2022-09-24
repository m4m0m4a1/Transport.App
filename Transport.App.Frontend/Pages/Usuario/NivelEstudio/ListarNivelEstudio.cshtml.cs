using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarNivelEstudioModel : PageModel
    {
        private readonly IRepositorioNivelEstudio _repoNivelEstudio = new RepositorioNivelEstudio( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <NivelEstudio> nivelEstudios {get; set;}
        public void OnGet()
        {
            nivelEstudios = _repoNivelEstudio.GetAllNivelEstudio();
        }

        public IActionResult OnPost(int Id)
        {
            _repoNivelEstudio.DeleteNivelEstudio(Id);
            return RedirectToAction("Get");
        }
    }
}
