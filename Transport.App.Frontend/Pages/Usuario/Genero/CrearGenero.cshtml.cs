using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearGeneroModel : PageModel
    {
        private readonly IRepositorioGenero _repoGenero = new RepositorioGenero( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public Genero NewGenero {get; set;}
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoGenero.AddGenero(NewGenero);
            return RedirectToPage("./ListarGenero");
        }
    }
}
