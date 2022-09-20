using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarTipoVehiculoModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public TipoVehiculo tipoVehiculosEdit {get; set;}
        public IActionResult OnGet(int? Id)
        {
            if( Id.HasValue )
            {
                tipoVehiculosEdit = _repoTipoVehiculo.GetTipoVehiculo(Id.Value);
            }else{
                tipoVehiculosEdit = new TipoVehiculo();
            }

            if(tipoVehiculosEdit == null)
            {
                return RedirectToPage("./NotFound");
            }else
            return Page();
        }

        public IActionResult OnPost()
        {
            tipoVehiculosEdit = _repoTipoVehiculo.UpdateTipoVehiculo(tipoVehiculosEdit);
            /*
            if(ModelState.IsValid)
            {
                return Page();
            }
            if(tipoVehiculosEdit.Id>0)
            {
                tipoVehiculosEdit = _repoTipoVehiculo.UpdateTipoVehiculo(tipoVehiculosEdit);
            }else{
                _repoTipoVehiculo.AddTipoVehiculo(tipoVehiculosEdit);
            }
            */
            return RedirectToPage("/Vehiculo/ListarTipoVehiculo");
            
        }
    }
}
