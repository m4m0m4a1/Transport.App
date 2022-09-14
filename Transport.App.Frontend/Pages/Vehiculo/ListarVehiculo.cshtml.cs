using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio;
using Transport.App.Persistencia;

namespace Transport.App.Frontend.Pages
{
    public class ListarVehiculoModel : PageModel
    {
        /*
        private readonly IRepositorioTipoVehiculo _irepositorioVehiculo;

        public ListarVehiculoModel(IRepositorioTipoVehiculo irepositorioVehiculo)
        {
            _irepositorioVehiculo = irepositorioVehiculo;
        }

        public IEnumerable<TipoVehiculo> TipoVehiculos {get; set;}
        */

        public void OnGet()
        {
          //  TipoVehiculos = _irepositorioVehiculo.GetAllTipoVehiculo();
        }
    }
}
