using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioGenero : IRepositorioGenero
{

    ///<summary>
    ///Referencia al contexto de Genero
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioGenero()
    {
    }

    public RepositorioGenero(AppContext appContext)
    {
        _appContext = appContext;
    }


    Genero IRepositorioGenero.AddGenero(Genero Genero)
    {
        var GeneroAdicionado = _appContext.Genero.Add(Genero);
        _appContext.SaveChanges();
        return GeneroAdicionado.Entity;
    }

    void IRepositorioGenero.DeleteGenero(int IdGenero)
    {

        var GeneroEncontrado = _appContext.Genero.FirstOrDefault(g => g.Id == IdGenero);
        if (GeneroEncontrado == null)
            return;
        _appContext.Genero.Remove(GeneroEncontrado);
        _appContext.SaveChanges();
    }


    IEnumerable<Genero> IRepositorioGenero.GetAllGenero()
    {

        return _appContext.Genero;
    }


    Genero IRepositorioGenero.GetGenero(int IdGenero)
    {

        return _appContext.Genero.FirstOrDefault(g => g.Id == IdGenero);
    }

    Genero IRepositorioGenero.UpdateGenero(Genero Genero)
    {
        var GeneroEncontrado = _appContext.Genero.FirstOrDefault(g => g.Id == Genero.Id);
        if (GeneroEncontrado != null)
        {

            GeneroEncontrado.Descripcion = Genero.Descripcion;

            _appContext.SaveChanges();

        }
        return GeneroEncontrado;

    }

}
