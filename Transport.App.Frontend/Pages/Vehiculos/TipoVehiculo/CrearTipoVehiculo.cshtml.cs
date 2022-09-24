using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class CrearTipoVehiculoModel : PageModel
    {
        private readonly IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        [BindProperty]
        public TipoVehiculo NewTipoVehiculo {get; set;}
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoTipoVehiculo.AddTipoVehiculo(NewTipoVehiculo);
            return RedirectToPage("./ListarTipoVehiculo");
        }
    }
}
