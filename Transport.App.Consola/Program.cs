using System;
using Transport.App.Dominio;
using Transport.App.Persistencia;

namespace Transport.App.Consola
{
    class Program
    {
         private static IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());

      static void Main(string[] args)
        {
            Console.WriteLine("Hello Worl Entity Framework!");
            AddVehiculo();
        }

        private static void AddVehiculo()
        {
          var vehiculo = new Vehiculo
          {
            FkPersona = 1,
            FkTipoVehiculo = 2,
            Placa = "JKF755",
            Marca = "Hyunday",
            Modelo = "2013",
            CapacidadPasajeros = 5,
            CilindrajeMotor = 1500,
            Color = "verde",
          };
         _repoVehiculo.AddVehiculo(vehiculo);
        }  
    }
}
