using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioSeguro : IRepositorioSeguro
{

    ///<summary>
    ///Referencia al contexto de Seguro
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioSeguro(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioSeguro()
    {
    }

    Seguro IRepositorioSeguro.AddSeguro(Seguro Seguro)
    {
        var SeguroAdicionado = _appContext.Seguro.Add(Seguro);
        _appContext.SaveChanges();
        return SeguroAdicionado.Entity;
    }

    void IRepositorioSeguro.DeleteSeguro(int IdSeguro)
    {

        var SeguroEncontrado = _appContext.Seguro.FirstOrDefault(s => s.Id == IdSeguro);
        if (SeguroEncontrado == null)
            return;
        _appContext.Seguro.Remove(SeguroEncontrado);
        _appContext.SaveChanges();
    }


    IEnumerable<Seguro> IRepositorioSeguro.GetAllSeguro()
    {

        return _appContext.Seguro;
    }


    Seguro IRepositorioSeguro.GetSeguro(int IdSeguro)
    {

        return _appContext.Seguro.FirstOrDefault(s => s.Id == IdSeguro);
    }

    Seguro IRepositorioSeguro.UpdateSeguro(Seguro Seguro)
    {
        var SeguroEncontrado = _appContext.Seguro.FirstOrDefault(s => s.Id == Seguro.Id);
        if (SeguroEncontrado != null)
        {
            SeguroEncontrado.FkVehiculo = Seguro.FkVehiculo;
            SeguroEncontrado.FkTipoSeguro = Seguro.FkTipoSeguro;
            SeguroEncontrado.FechaCompra = Seguro.FechaCompra;
            SeguroEncontrado.FechaVencimiento = Seguro.FechaVencimiento;

            _appContext.SaveChanges();

        }
        return Seguro;

    }

}