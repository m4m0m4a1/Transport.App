using System.Collections.Generic;
using Transport.App.Dominio.Entidades;


namespace Transport.App.Persistencia.AppRepositorios;
public interface IRepositorioGenero
{
    IEnumerable<Genero> GetAllGenero();
    Genero AddGenero(Genero Genero);
    Genero UpdateGenero(Genero Genero);
    void DeleteGenero(int IdGenero);
    Genero GetGenero(int IdGenero);
}