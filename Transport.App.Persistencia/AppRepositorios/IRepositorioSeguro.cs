using System.Collections.Generic;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;

public interface IRepositorioSeguro
{

    IEnumerable<Seguro> GetAllSeguro();
    Seguro AddSeguro(Seguro Seguro);
    Seguro UpdateSeguro(Seguro Seguro);
    void DeleteSeguro(int IdSeguro);
    Seguro GetSeguro(int IdSeguro);

}