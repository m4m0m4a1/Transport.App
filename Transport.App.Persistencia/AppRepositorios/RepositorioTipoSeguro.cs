using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioTipoSeguro : IRepositorioTipoSeguro
{

    ///<summary>
    ///Referencia al contexto de Tipo de Seguro (SOAT, Contractual, Extracontractual)
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioTipoSeguro(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioTipoSeguro()
    {
    }

    TipoSeguro IRepositorioTipoSeguro.AddTipoSeguro(TipoSeguro TipoSeguro)
    {
        var TipoSeguroAdicionado = _appContext.TipoSeguro.Add(TipoSeguro);
        _appContext.SaveChanges();
        return TipoSeguroAdicionado.Entity;
    }

    void IRepositorioTipoSeguro.DeleteTipoSeguro(int IdTipoSeguro)
    {

        var TipoSeguroEncontrado = _appContext.TipoSeguro.FirstOrDefault(t => t.Id == IdTipoSeguro);
        if (TipoSeguroEncontrado == null)
            return;
        _appContext.TipoSeguro.Remove(TipoSeguroEncontrado);
        _appContext.SaveChanges();
    }


    IEnumerable<TipoSeguro> IRepositorioTipoSeguro.GetAllTipoSeguro()
    {

        return _appContext.TipoSeguro;
    }


    TipoSeguro IRepositorioTipoSeguro.GetTipoSeguro(int IdTipoSeguro)
    {

        return _appContext.TipoSeguro.FirstOrDefault(t => t.Id == IdTipoSeguro);
    }

    TipoSeguro IRepositorioTipoSeguro.UpdateTipoSeguro(TipoSeguro TipoSeguro)
    {
        var TipoSeguroEncontrado = _appContext.TipoSeguro.FirstOrDefault(t => t.Id == TipoSeguro.Id);
        if (TipoSeguroEncontrado != null)
        {
            TipoSeguroEncontrado.Descripcion = TipoSeguro.Descripcion;

            _appContext.SaveChanges();

        }
        return TipoSeguro;

    }

}