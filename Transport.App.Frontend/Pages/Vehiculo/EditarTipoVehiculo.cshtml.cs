using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarTipoVehiculoModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        public TipoVehiculo tipoVehiculosEdit {get; set;}
        public IActionResult OnGet(int Id)
        {
            tipoVehiculosEdit = _repoTipoVehiculo.GetTipoVehiculo(Id);
            return Page();
        }

        public void OnPost()
        {
            /*
            if( !ModelState.IsValid )
            {
                return Page();
            }
            */
            tipoVehiculosEdit = _repoTipoVehiculo.UpdateTipoVehiculo(tipoVehiculosEdit);
            //return Redirect("./ListarTipoVehiculo");
        }
    }
}
