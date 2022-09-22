using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioPersona : IRepositorioPersona
{

    ///<summary>
    ///Referencia al contexto de Persona
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioPersona(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioPersona()
    {
    }

    Persona IRepositorioPersona.AddPersona(Persona Persona)
    {
        var PersonaAdicionada = _appContext.Persona.Add(Persona);
        _appContext.SaveChanges();
        return PersonaAdicionada.Entity;
    }

    void IRepositorioPersona.DeletePersona(int IdPersona)
    {

        var PersonaEncontrada = _appContext.Persona.FirstOrDefault(p => p.Id == IdPersona);
        if (PersonaEncontrada == null)
            return;
        _appContext.Persona.Remove(PersonaEncontrada);
        _appContext.SaveChanges();
    }

    IEnumerable<Persona> IRepositorioPersona.GetAllPersona()
    {

        return _appContext.Persona;
    }


    Persona IRepositorioPersona.GetPersona(int IdPersona)
    {

        return _appContext.Persona.FirstOrDefault(p => p.Id == IdPersona);
    }

    Persona IRepositorioPersona.UpdatePersona(Persona Persona)
    {
        var PersonaEncontrada = _appContext.Persona.FirstOrDefault(p => p.Id == Persona.Id);
        if (PersonaEncontrada != null)
        {

            PersonaEncontrada.FkTipoDocumento = Persona.FkTipoDocumento;
            PersonaEncontrada.Identificacion = Persona.Identificacion;
            PersonaEncontrada.Nombre = Persona.Nombre;
            PersonaEncontrada.Apellido = Persona.Apellido;
            PersonaEncontrada.FkGenero = Persona.FkGenero;
            PersonaEncontrada.FkRol = Persona.FkRol;
            PersonaEncontrada.FkNivelEstudios = Persona.FkNivelEstudios;
            PersonaEncontrada.FechaNacimiento = Persona.FechaNacimiento;
            PersonaEncontrada.Telefono = Persona.Telefono;
            PersonaEncontrada.Correo = Persona.Correo;
            PersonaEncontrada.Direccion = Persona.Direccion;

            _appContext.SaveChanges();

        }
        return PersonaEncontrada;

    }

}