using System.Collections.Generic;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public interface IRepositorioNivelEstudio
{
    IEnumerable<NivelEstudio> GetAllNivelEstudio();
    NivelEstudio AddNivelEstudio(NivelEstudio NivelEstudio);
    NivelEstudio UpdateNivelEstudio(NivelEstudio NivelEstudio);
    void DeleteNivelEstudio(int IdNivelEstudio);
    NivelEstudio GetNivelEstudio(int IdNivelEstudio);

}