using System.Collections.Generic;
using Transport.App.Dominio;


namespace Transport.App.Persistencia

{

public interface IRepositorioRol
{

    IEnumerable<Rol> GetAllRol();

    Rol AddRol(Rol Rol);
    Rol UpdateRol(Rol Rol);
    void DeleteRol(int IdRol);
    Rol GetRol(int IdRol);

}

}