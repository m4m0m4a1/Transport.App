using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarSeguroModel : PageModel
    {
        private readonly IRepositorioSeguro _repoSeguro = new RepositorioSeguro( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioTipoSeguro _repoTipoSeguro = new RepositorioTipoSeguro(new Persistencia.AppRepositorios.AppContext());
        public readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppRepositorios.AppContext());
        public IEnumerable<Seguro> seguros { get; set; }
        public void OnGet()
        {
            seguros = _repoSeguro.GetAllSeguro();
        }

        public IActionResult OnPost(int Id)
        {
            _repoSeguro.DeleteSeguro(Id);
            return RedirectToAction("Get");
        }
    }
}
