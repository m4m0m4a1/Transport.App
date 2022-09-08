using System.Collections.Generic;
using Transport.App.Dominio;


namespace Transport.App.Persistencia

{

public interface IRepositorioTipoSeguro
{

    IEnumerable<TipoSeguro> GetAllTipoSeguro();

    TipoSeguro AddTipoSeguro(TipoSeguro TipoSeguro);
    TipoSeguro UpdateTipoSeguro(TipoSeguro TipoSeguro);
    void DeleteTipoSeguro(int IdTipoSeguro);
    TipoSeguro GetTipoSeguro(int IdTipoSeguro);

}

}