using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarTipoSeguroModel : PageModel
    {
        private readonly IRepositorioTipoSeguro _repoTipoSeguro = new RepositorioTipoSeguro(new Persistencia.AppRepositorios.AppContext());
        public IEnumerable<TipoSeguro> tiposeguros { get; set; }
        public void OnGet()
        {
            tiposeguros = _repoTipoSeguro.GetAllTipoSeguro();
        }

        public IActionResult OnPost(int Id)
        {
            _repoTipoSeguro.DeleteTipoSeguro(Id);
            return RedirectToAction("Get");
        }
    }
}