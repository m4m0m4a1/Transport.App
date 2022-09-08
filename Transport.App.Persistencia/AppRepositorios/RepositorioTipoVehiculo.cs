using System.Collections.Generic;
using System.Linq;
using Transport.App.Dominio;

namespace Transport.App.Persistencia
{
    public class RepositorioTipoVehiculo : IRepositorioTipoVehiculo
    {

        ///<summary>
        ///Referencia al contexto de Tipo de Vehiculo (Buseta, Micro bus)
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioTipoVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }


        TipoVehiculo IRepositorioTipoVehiculo.AddTipoVehiculo(TipoVehiculo TipoVehiculo)
        {
            var TipoVehiculoAdicionado = _appContext.TipoVehiculo.Add(TipoVehiculo);
            _appContext.SaveChanges();
            return TipoVehiculoAdicionado.Entity;
        }

        void IRepositorioTipoVehiculo.DeleteTipoVehiculo(int IdTipoVehiculo)
        {

            var TipoVehiculoEncontrado = _appContext.TipoVehiculo.FirstOrDefault(t => t.Id == IdTipoVehiculo);
            if (TipoVehiculoEncontrado == null)
                return;
            _appContext.TipoVehiculo.Remove(TipoVehiculoEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<TipoVehiculo> IRepositorioTipoVehiculo.GetAllTipoVehiculo()
        {

            return _appContext.TipoVehiculo;
        }


        TipoVehiculo IRepositorioTipoVehiculo.GetTipoVehiculo(int IdTipoVehiculo)
        {

            return _appContext.TipoVehiculo.FirstOrDefault(t => t.Id == IdTipoVehiculo);
        }

        TipoVehiculo IRepositorioTipoVehiculo.UpdateTipoVehiculo(TipoVehiculo TipoVehiculo)
        {
            var TipoVehiculoEncontrado = _appContext.TipoVehiculo.FirstOrDefault(t => t.Id == TipoVehiculo.Id);
            if (TipoVehiculoEncontrado != null)
            {
                TipoVehiculoEncontrado.Descripcion = TipoVehiculo.Descripcion;

                _appContext.SaveChanges();

            }
            return TipoVehiculo;

        }

    }

}