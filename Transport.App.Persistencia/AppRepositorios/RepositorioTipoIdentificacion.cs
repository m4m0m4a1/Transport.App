using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioTipoIdentificacion : IRepositorioTipoIdentificacion
{

    ///<summary>
    ///Referencia al contexto de Tipo de Identificacion
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioTipoIdentificacion(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioTipoIdentificacion()
    {
    }

    TipoIdentificacion IRepositorioTipoIdentificacion.AddTipoIdentificacion(TipoIdentificacion TipoIdentificacion)
    {
        var TipoIdentificacionAdicionado = _appContext.TipoIdentificacion.Add(TipoIdentificacion);
        _appContext.SaveChanges();
        return TipoIdentificacionAdicionado.Entity;
    }

    void IRepositorioTipoIdentificacion.DeleteTipoIdentificacion(int IdTipoIdentificacion)
    {

        var TipoIdentificacionEncontrado = _appContext.TipoIdentificacion.FirstOrDefault(t => t.Id == IdTipoIdentificacion);
        if (TipoIdentificacionEncontrado == null)
            return;
        _appContext.TipoIdentificacion.Remove(TipoIdentificacionEncontrado);
        _appContext.SaveChanges();
    }


    IEnumerable<TipoIdentificacion> IRepositorioTipoIdentificacion.GetAllTipoIdentificacion()
    {

        return _appContext.TipoIdentificacion;
    }


    TipoIdentificacion IRepositorioTipoIdentificacion.GetTipoIdentificacion(int IdTipoIdentificacion)
    {
        return _appContext.TipoIdentificacion.FirstOrDefault(t => t.Id == IdTipoIdentificacion);
    }

    TipoIdentificacion IRepositorioTipoIdentificacion.UpdateTipoIdentificacion(TipoIdentificacion TipoIdentificacion)
    {
        var TipoIdentificacionEncontrado = _appContext.TipoIdentificacion.FirstOrDefault(t => t.Id == TipoIdentificacion.Id);
        if (TipoIdentificacionEncontrado != null)
        {
            TipoIdentificacionEncontrado.Descripcion = TipoIdentificacion.Descripcion;

            _appContext.SaveChanges();

        }
        return TipoIdentificacion;

    }

}