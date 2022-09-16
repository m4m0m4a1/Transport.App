using System.Collections.Generic;
using Transport.App.Dominio.Entidades;


namespace Transport.App.Persistencia.AppRepositorios;
public interface IRepositorioPersona
{
    IEnumerable<Persona> GetAllPersona();
    Persona AddPersona(Persona Persona);
    Persona UpdatePersona(Persona Persona);
    void DeletePersona(int IdPersona);
    Persona GetPersona(int IdPersona);

}