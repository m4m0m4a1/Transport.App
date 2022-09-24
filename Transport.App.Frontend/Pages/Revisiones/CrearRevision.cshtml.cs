using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;


namespace Transport.App.Frontend.Pages
{
    public class CrearRevisionModel : PageModel
    {    public readonly IRepositorioRevision _repoRevision = new RepositorioRevision(new Persistencia.AppRepositorios.AppContext());
         public readonly IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppRepositorios.AppContext());
         public readonly IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppRepositorios.AppContext());
         public IEnumerable <Revision> revision {get; set;}
         public IEnumerable <Persona> personas {get; set;}
         public IEnumerable <Vehiculo> vehiculos {get; set;}
         [BindProperty]
         public Revision NewRevision { get; set; }
         public void OnGet()
        {
            //revision = _repoRevision.GetAllRevision();
            vehiculos = _repoVehiculo.GetAllVehiculo();
            personas = _repoPersona.GetAllPersona();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _repoRevision.AddRevision(NewRevision);
            return RedirectToPage("./ListarRevision");
        }
    }
}