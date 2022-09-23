using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class ListarTipoVehiculoModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <TipoVehiculo> tipoVehiculos {get; set;}
        public void OnGet()
        {
            tipoVehiculos = _repoTipoVehiculo.GetAllTipoVehiculo();
        }
        public IActionResult OnPost(int Id)
        {
            _repoTipoVehiculo.DeleteTipoVehiculo(Id);
            return RedirectToAction("Get");
        }
    }
}
