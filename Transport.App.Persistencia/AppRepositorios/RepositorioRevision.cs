using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class RepositorioRevision : IRepositorioRevision
{

    ///<summary>
    ///Referencia al contexto de Revision
    ///</summary>

    private readonly AppContext _appContext;
    ///<summary>
    ///Metodo Constructos 
    /// Inyeccion de dependencias para indicar el contexto a utilizar
    ///</summary>
    ///<param name="appContext"></param>//

    public RepositorioRevision(AppContext appContext)
    {
        _appContext = appContext;
    }

    public RepositorioRevision()
    {
    }

    Revision IRepositorioRevision.AddRevision(Revision Revision)
    {
        var RevisionAdicionada = _appContext.Revision.Add(Revision);
        _appContext.SaveChanges();
        return RevisionAdicionada.Entity;
    }

    void IRepositorioRevision.DeleteRevision(int IdRevision)
    {

        var RevisionEncontrada = _appContext.Revision.FirstOrDefault(r => r.Id == IdRevision);
        if (RevisionEncontrada == null)
            return;
        _appContext.Revision.Remove(RevisionEncontrada);
        _appContext.SaveChanges();
    }


    IEnumerable<Revision> IRepositorioRevision.GetAllRevision()
    {

        return _appContext.Revision;
    }


    Revision IRepositorioRevision.GetRevision(int IdRevision)
    {

        return _appContext.Revision.FirstOrDefault(r => r.Id == IdRevision);
    }

    Revision IRepositorioRevision.UpdateRevision(Revision Revision)
    {
        var RevisionEncontrada = _appContext.Revision.FirstOrDefault(r => r.Id == Revision.Id);
        if (RevisionEncontrada != null)
        {

            RevisionEncontrada.FkVehiculo = Revision.FkVehiculo;
            RevisionEncontrada.FkMecanico = Revision.FkMecanico;
            RevisionEncontrada.NivelAceite = Revision.NivelAceite;
            RevisionEncontrada.FechaNivelAceite = Revision.FechaNivelAceite;
            RevisionEncontrada.NivelFrenos = Revision.NivelFrenos;
            RevisionEncontrada.FechaNivelFrenos = Revision.FechaNivelFrenos;
            RevisionEncontrada.NivelRefrigerante = Revision.NivelRefrigerante;
            RevisionEncontrada.FechaNivelRefrigerante = Revision.FechaNivelRefrigerante;
            RevisionEncontrada.NivelDireccion = Revision.NivelDireccion;
            RevisionEncontrada.FechaNivelDireccion = Revision.FechaNivelDireccion;
            RevisionEncontrada.Observacion = Revision.Observacion;

            _appContext.SaveChanges();

        }
        return RevisionEncontrada;

    }

}