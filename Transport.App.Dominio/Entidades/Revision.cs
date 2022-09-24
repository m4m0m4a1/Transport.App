using System;
namespace Transport.App.Dominio.Entidades;
public class Revision
{
    public int Id { get; set; }
    public int FkVehiculo { get; set; }
    public int FkMecanico { get; set; }
    public string NivelAceite { get; set; }
    public DateTime FechaNivelAceite { get; set; }
    public string NivelFrenos { get; set; }
    public DateTime FechaNivelFrenos { get; set; }
    public string NivelRefrigerante { get; set; }
    public DateTime FechaNivelRefrigerante { get; set; }
    public string NivelDireccion { get; set; }
    public DateTime FechaNivelDireccion { get; set; }
    public string Observacion { get; set; }
}    