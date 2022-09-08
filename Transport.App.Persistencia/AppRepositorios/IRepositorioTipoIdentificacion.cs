using System.Collections.Generic;
using Transport.App.Dominio;


namespace Transport.App.Persistencia

{

public interface IRepositorioTipoIdentificacion
{

    IEnumerable<TipoIdentificacion> GetAllTipoIdentificacion();

    TipoIdentificacion AddTipoIdentificacion(TipoIdentificacion TipoIdentificacion);
    TipoIdentificacion UpdateTipoIdentificacion(TipoIdentificacion TipoIdentificacion);
    void DeleteTipoIdentificacion(int IdTipoIdentificacion);
    TipoIdentificacion GetTipoIdentificacion(int IdTipoIdentificacion);

}

}