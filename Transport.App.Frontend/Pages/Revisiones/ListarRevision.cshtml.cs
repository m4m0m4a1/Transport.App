using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;


namespace Transport.App.Frontend.Pages
{
    public class ListarRevisionModel : PageModel
    {
        private readonly IRepositorioRevision _repoRevision= new RepositorioRevision(new Persistencia.AppRepositorios.AppContext());
        public readonly IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppRepositorios.AppContext());
        public readonly IRepositorioVehiculo _repoVehiculo= new RepositorioVehiculo(new Persistencia.AppRepositorios.AppContext());
        public IEnumerable <Revision> lrevision {get; set;}
        public void OnGet()
        {
            lrevision = _repoRevision.GetAllRevision();
        }

        public IActionResult OnPost(int Id)
        {
            _repoRevision.DeleteRevision(Id);
            return RedirectToAction("Get");
        }
    }
}
