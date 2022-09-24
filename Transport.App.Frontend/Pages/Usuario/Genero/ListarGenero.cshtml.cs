using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarGeneroModel : PageModel
    {
        private readonly IRepositorioGenero _repoGenero = new RepositorioGenero( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <Genero> generos {get; set;}
        public void OnGet()
        {
            generos = _repoGenero.GetAllGenero();
        }

        public IActionResult OnPost(int Id)
        {
            _repoGenero.DeleteGenero(Id);
            return RedirectToAction("Get");
        }
    }
}
