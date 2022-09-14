using System;
namespace Transport.App.Dominio.Entidades;
public class Vehiculo
{

    public int Id { get; set; }
    public int FkPersona { get; set; }
    public int FkTipoVehiculo { get; set; }
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Marca { get; set; }
    public int CapacidadPasajeros { get; set; }
    public string CilindrajeMotor { get; set; }
    public string Color { get; set; }
    public string Pais { get; set; }

}