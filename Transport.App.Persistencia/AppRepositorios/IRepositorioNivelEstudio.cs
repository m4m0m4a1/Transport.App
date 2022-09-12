using System.Collections.Generic;
using Transport.App.Dominio;


namespace Transport.App.Persistencia

{

public interface IRepositorioNivelEstudio
{

    IEnumerable<NivelEstudio> GetAllNivelEstudio();

    NivelEstudio AddNivelEstudio(NivelEstudio NivelEstudio);
    NivelEstudio UpdateNivelEstudio(NivelEstudio NivelEstudio);
    void DeleteNivelEstudio(int IdNivelEstudio);
    NivelEstudio GetNivelEstudio(int IdNivelEstudio);

}

}