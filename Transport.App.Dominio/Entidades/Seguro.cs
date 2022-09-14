using System;
namespace Transport.App.Dominio.Entidades;
public class Seguro
{
    public int Id { get; set; }
    public int FkVehiculo { get; set; }
    public int FkTipoSeguro { get; set; }
    public DateTime FechaCompra { get; set; }
    public DateTime FechaVencimiento { get; set; }

}