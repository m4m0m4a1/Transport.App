using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;

public class RepositorioVehiculo : IRepositorioVehiculo
{

    ///<summary>
    ///Referencia al contexto de Vehiculo (Buseta, Micro bus)
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioVehiculo(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioVehiculo()
    {
    }

    Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo Vehiculo)
    {
        var VehiculoAdicionado = _appContext.Vehiculo.Add(Vehiculo);
        _appContext.SaveChanges();
        return VehiculoAdicionado.Entity;
    }

    void IRepositorioVehiculo.DeleteVehiculo(int IdVehiculo)
    {

        var VehiculoEncontrado = _appContext.Vehiculo.FirstOrDefault(v => v.Id == IdVehiculo);
        if (VehiculoEncontrado == null)
            return;
        _appContext.Vehiculo.Remove(VehiculoEncontrado);
        _appContext.SaveChanges();
    }


    IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculo()
    {

        return _appContext.Vehiculo;
    }


    Vehiculo IRepositorioVehiculo.GetVehiculo(int IdVehiculo)
    {

        return _appContext.Vehiculo.FirstOrDefault(v => v.Id == IdVehiculo);
    }

    Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo Vehiculo)
    {
        var VehiculoEncontrado = _appContext.Vehiculo.FirstOrDefault(v => v.Id == Vehiculo.Id);
        if (VehiculoEncontrado != null)
        {
            VehiculoEncontrado.FkPersona = Vehiculo.FkPersona;
            VehiculoEncontrado.FkTipoVehiculo = Vehiculo.FkTipoVehiculo;
            VehiculoEncontrado.Placa = Vehiculo.Placa;
            VehiculoEncontrado.Modelo = Vehiculo.Modelo;
            VehiculoEncontrado.Marca = Vehiculo.Marca;
            VehiculoEncontrado.CapacidadPasajeros = Vehiculo.CapacidadPasajeros;
            VehiculoEncontrado.CilindrajeMotor = Vehiculo.CilindrajeMotor;
            VehiculoEncontrado.Color = Vehiculo.Color;
            VehiculoEncontrado.Pais = Vehiculo.Pais;

            _appContext.SaveChanges();

        }
        return Vehiculo;

    }

}
