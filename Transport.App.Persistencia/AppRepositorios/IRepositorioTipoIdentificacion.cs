using System.Collections.Generic;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public interface IRepositorioTipoIdentificacion
{
    IEnumerable<TipoIdentificacion> GetAllTipoIdentificacion();
    TipoIdentificacion AddTipoIdentificacion(TipoIdentificacion TipoIdentificacion);
    TipoIdentificacion UpdateTipoIdentificacion(TipoIdentificacion TipoIdentificacion);
    void DeleteTipoIdentificacion(int IdTipoIdentificacion);
    TipoIdentificacion GetTipoIdentificacion(int IdTipoIdentificacion);

}