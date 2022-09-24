using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearTipoSeguroModel : PageModel
    {
        private readonly IRepositorioTipoSeguro _repoTipoSeguro = new RepositorioTipoSeguro(new Persistencia.AppRepositorios.AppContext());
        [BindProperty]
        public TipoSeguro NewTipoSeguro { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoTipoSeguro.AddTipoSeguro(NewTipoSeguro);
            return RedirectToPage("./ListarTipoSeguro");
        }
    }
}
