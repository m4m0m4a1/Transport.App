using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;


namespace Transport.App.Frontend.Pages
{
    public class ListarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioPersona _repoPersona = new RepositorioPersona( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <Vehiculo> lsvehiculos {get; set;}
        public void OnGet()
        {
            lsvehiculos = _repoVehiculo.GetAllVehiculo();
        }
        public IActionResult OnPost(int Id)
        {
            _repoVehiculo.DeleteVehiculo(Id);
            return RedirectToAction("Get");
        }
    }
}
