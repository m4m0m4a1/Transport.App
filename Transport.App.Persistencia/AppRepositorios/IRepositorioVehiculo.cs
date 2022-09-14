using System.Collections.Generic;
using Transport.App.Dominio.Entidades;


namespace Transport.App.Persistencia.AppRepositorios;
public interface IRepositorioVehiculo
{

    IEnumerable<Vehiculo> GetAllVehiculo();
    Vehiculo AddVehiculo(Vehiculo Vehiculo);
    Vehiculo UpdateVehiculo(Vehiculo Vehiculo);
    void DeleteVehiculo(int IdVehiculo);
    Vehiculo GetVehiculo(int IdVehiculo);

}