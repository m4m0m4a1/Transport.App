using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarVehiculoModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppRepositorios.AppContext());
        private readonly IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        private readonly IRepositorioPersona _repoPersona = new RepositorioPersona( new Persistencia.AppRepositorios.AppContext() );
        public IEnumerable <Vehiculo> vehiculos {get; set;}
        public IEnumerable <Persona> personas {get; set;}
        public IEnumerable <TipoVehiculo> tipoVehiculos {get; set;}
        [BindProperty]
        public Vehiculo? EditVehiculo { get; set; } 

        public IActionResult OnGet(int? Id)
        {
            vehiculos = _repoVehiculo.GetAllVehiculo();
            tipoVehiculos = _repoTipoVehiculo.GetAllTipoVehiculo();
            personas = _repoPersona.GetAllPersona();
            
                if (Id.HasValue)
                {
                    EditVehiculo = _repoVehiculo.GetVehiculo(Id.Value);
                }
                else
                {
                    EditVehiculo = new Vehiculo();
                }
                if (EditVehiculo == null)
                {
                    return RedirectToPage("./NotFound");
                }
                else
                return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repoVehiculo.UpdateVehiculo(EditVehiculo);
            return RedirectToPage("./ListarVehiculo");
        }
    }
}