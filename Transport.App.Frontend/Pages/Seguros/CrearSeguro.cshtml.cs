using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;


namespace Transport.App.Frontend.Pages
{
    public class CrearSeguroModel : PageModel
    {
        private readonly IRepositorioSeguro _repoSeguro = new RepositorioSeguro( new Persistencia.AppRepositorios.AppContext() );
        public readonly IRepositorioTipoSeguro _repoTipoSeguro = new RepositorioTipoSeguro(new Persistencia.AppRepositorios.AppContext());
        public readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppRepositorios.AppContext());
        public IEnumerable <TipoSeguro> tiposeg {get; set;}
        public IEnumerable <TipoVehiculo> tipoveh {get; set;}
        public IEnumerable <Vehiculo> lsvehiculos {get; set;}
        [BindProperty]
        public Seguro NewSeguro {get; set;}
        public void OnGet()
        {
            tiposeg = _repoTipoSeguro.GetAllTipoSeguro();
            lsvehiculos = _repoVehiculo.GetAllVehiculo();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Console.WriteLine("AddPersona web: "+ NewSeguro.Id+" "+NewSeguro.FkVehiculo+" "+NewSeguro.FkTipoSeguro);
            _repoSeguro.AddSeguro(NewSeguro);
            return RedirectToPage("./ListarSeguro");
        }
    }
}
