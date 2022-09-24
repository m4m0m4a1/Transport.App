using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioNivelEstudio : IRepositorioNivelEstudio
{

    ///<summary>
    ///Referencia al contexto de Nivel de Estudios
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioNivelEstudio(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioNivelEstudio()
    {
    }

    NivelEstudio IRepositorioNivelEstudio.AddNivelEstudio(NivelEstudio NivelEstudio)
    {
        var NivelEstudioAdicionado = _appContext.NivelEstudio.Add(NivelEstudio);
        _appContext.SaveChanges();
        return NivelEstudioAdicionado.Entity;
    }

    void IRepositorioNivelEstudio.DeleteNivelEstudio(int IdNivelEstudio)
    {
        var NivelEstudioEncontrado = _appContext.NivelEstudio.FirstOrDefault(n => n.Id == IdNivelEstudio);
        if (NivelEstudioEncontrado == null)
            return;
        _appContext.NivelEstudio.Remove(NivelEstudioEncontrado);
        _appContext.SaveChanges();
    }

    IEnumerable<NivelEstudio> IRepositorioNivelEstudio.GetAllNivelEstudio()
    {
        return _appContext.NivelEstudio;
    }

    NivelEstudio IRepositorioNivelEstudio.GetNivelEstudio(int IdNivelEstudio)
    {
        return _appContext.NivelEstudio.FirstOrDefault(n => n.Id == IdNivelEstudio);
    }

    NivelEstudio IRepositorioNivelEstudio.UpdateNivelEstudio(NivelEstudio NivelEstudio)
    {
        var NivelEstudioEncontrado = _appContext.NivelEstudio.FirstOrDefault(n => n.Id == NivelEstudio.Id);
        if (NivelEstudioEncontrado != null)
        {

            NivelEstudioEncontrado.Descripcion = NivelEstudio.Descripcion;

            _appContext.SaveChanges();

        }
        return NivelEstudioEncontrado;

    }

}