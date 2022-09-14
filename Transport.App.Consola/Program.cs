using System;
using Transport.App.Dominio.Entidades;
using Transport.App.Persistencia.AppRepositorios;

namespace Transport.App.Consola
{
    class Program
    {
        private static IRepositorioTipoVehiculo _repoTipoVehiculo = new RepositorioTipoVehiculo( new Persistencia.AppRepositorios.AppContext() );
        public static IEnumerable <TipoVehiculo> ltvehiculo {get; set;}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Worl Entity Framework!");
            //AddTipoVehiculo();
            GetAllTipoVehiculo();

        }

        private static void AddTipoVehiculo()
        {
            var tvehiculo = new TipoVehiculo
            {
                Descripcion = "Microbuseta"
            };
            
            _repoTipoVehiculo.AddTipoVehiculo(tvehiculo);
            Console.WriteLine("Tipo Vehiculo agregado!");
        }

        private static void GetAllTipoVehiculo()
        {            
            ltvehiculo =_repoTipoVehiculo.GetAllTipoVehiculo();
            Console.WriteLine("Listado de tipo Vehiculo");
            Console.WriteLine(" "+ltvehiculo.Count());
        }
    }
}
