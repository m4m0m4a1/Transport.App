using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioRol : IRepositorioRol
{

    ///<summary>
    ///Referencia al contexto de Rol (Mecanica, Auxiliar, Jefe de Operaciones, Dueño, Conductor)
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioRol(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioRol()
    {
    }

    Rol IRepositorioRol.AddRol(Rol Rol)
    {
        var RolAdicionado = _appContext.Rol.Add(Rol);
        _appContext.SaveChanges();
        return RolAdicionado.Entity;
    }

    void IRepositorioRol.DeleteRol(int IdRol)
    {

        var RolEncontrado = _appContext.Rol.FirstOrDefault(r => r.Id == IdRol);
        if (RolEncontrado == null)
            return;
        _appContext.Rol.Remove(RolEncontrado);
        _appContext.SaveChanges();
    }


    IEnumerable<Rol> IRepositorioRol.GetAllRol()
    {

        return _appContext.Rol;
    }


    Rol IRepositorioRol.GetRol(int IdRol)
    {

        return _appContext.Rol.FirstOrDefault(r => r.Id == IdRol);
    }

    Rol IRepositorioRol.UpdateRol(Rol Rol)
    {
        var RolEncontrado = _appContext.Rol.FirstOrDefault(r => r.Id == Rol.Id);
        if (RolEncontrado != null)
        {

            RolEncontrado.Descripcion = Rol.Descripcion;

            _appContext.SaveChanges();

        }
        return Rol;

    }

}