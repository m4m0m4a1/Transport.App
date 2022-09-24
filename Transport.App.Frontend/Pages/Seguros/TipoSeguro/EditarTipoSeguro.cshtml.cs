using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Frontend.Pages
{
    public class EditarTipoSeguroModel : PageModel
    {
    private readonly IRepositorioTipoSeguro _repoTipoSeguro = new RepositorioTipoSeguro(new Persistencia.AppRepositorios.AppContext());
    [BindProperty]
    public TipoSeguro? EditTipoSeguro { get; set; }
    public IActionResult OnGet(int? Id)
    {
        if (Id.HasValue)
        {
            EditTipoSeguro = _repoTipoSeguro.GetTipoSeguro(Id.Value);
        }
        else
        {
            EditTipoSeguro = new TipoSeguro();
        }
        if (EditTipoSeguro == null)
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
        _repoTipoSeguro.UpdateTipoSeguro(EditTipoSeguro);
        return RedirectToPage("./ListarTipoSeguro");
    }
}
}