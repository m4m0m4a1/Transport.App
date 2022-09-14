using System.Collections.Generic;
using Transport.App.Dominio.Entidades;


namespace Transport.App.Persistencia.AppRepositorios;

public interface IRepositorioTipoSeguro
{

    IEnumerable<TipoSeguro> GetAllTipoSeguro();

    TipoSeguro AddTipoSeguro(TipoSeguro TipoSeguro);
    TipoSeguro UpdateTipoSeguro(TipoSeguro TipoSeguro);
    void DeleteTipoSeguro(int IdTipoSeguro);
    TipoSeguro GetTipoSeguro(int IdTipoSeguro);

}