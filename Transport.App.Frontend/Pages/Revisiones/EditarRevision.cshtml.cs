using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarRevisionModel : PageModel
    {
         private readonly IRepositorioRevision _repoRevision = new RepositorioRevision(new Persistencia.AppRepositorios.AppContext());
         private readonly IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppRepositorios.AppContext());
         private readonly IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppRepositorios.AppContext());
         public IEnumerable <Revision> revision {get; set;}
         public IEnumerable <Persona> personas {get; set;}
         public IEnumerable <Vehiculo> vehiculos {get; set;}
         [BindProperty]
         public Revision? EditRevision { get; set; }
         public IActionResult OnGet(int? Id)
        {
              //revision = _repoRevision.GetAllRevision();
            vehiculos = _repoVehiculo.GetAllVehiculo();
            personas = _repoPersona.GetAllPersona();

                if (Id.HasValue)
                    {
                        EditRevision = _repoRevision.GetRevision(Id.Value);
                    }
                    else
                    {
                        EditRevision = new Revision();
                    }
                    if (EditRevision == null)
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
            _repoRevision.UpdateRevision(EditRevision);
            return RedirectToPage("./ListarRevision");
        }
    }
}
    