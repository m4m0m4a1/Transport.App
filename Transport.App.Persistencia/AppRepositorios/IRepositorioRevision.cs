using System.Collections.Generic;
using Transport.App.Dominio.Entidades;


namespace Transport.App.Persistencia.AppRepositorios;

public interface IRepositorioRevision
{

    IEnumerable<Revision> GetAllRevision();

    Revision AddRevision(Revision Revision);
    Revision UpdateRevision(Revision Revision);
    void DeleteRevision(int IdRevision);
    Revision GetRevision(int IdRevision);

}