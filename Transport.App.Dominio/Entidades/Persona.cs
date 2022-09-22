using System;
namespace Transport.App.Dominio.Entidades;
public class Persona
{
    public int Id { get; set; }
    public int FkTipoDocumento { get; set; }
    public int Identificacion { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int FkGenero { get; set; }
    public int FkRol { get; set; }
    public int FkNivelEstudios { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string Telefono { get; set; }
    public string Correo { get; set; }
    public string Direccion { get; set; }

}