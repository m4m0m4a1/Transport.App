using System.Collections.Generic;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;

public interface IRepositorioTipoVehiculo
{
    IEnumerable<TipoVehiculo> GetAllTipoVehiculo();
    TipoVehiculo AddTipoVehiculo(TipoVehiculo TipoVehiculo);
    TipoVehiculo UpdateTipoVehiculo(TipoVehiculo TipoVehiculo);
    void DeleteTipoVehiculo(int IdTipoVehiculo);
    TipoVehiculo GetTipoVehiculo(int IdTipoVehiculo);

}