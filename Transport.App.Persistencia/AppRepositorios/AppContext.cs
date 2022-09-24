using Microsoft.EntityFrameworkCore;
using Transport.App.Dominio.Entidades;

namespace Transport.App.Persistencia.AppRepositorios;
public class AppContext : DbContext
{
    public DbSet<Persona> Persona { get; set; }
    public DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<Genero> Genero { get; set; }
    public DbSet<NivelEstudio> NivelEstudio { get; set; }
    public DbSet<Seguro> Seguro { get; set; }
    public DbSet<TipoSeguro> TipoSeguro { get; set; }
    public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
    public DbSet<Vehiculo> Vehiculo { get; set; }
    public DbSet<Revision> Revision { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            //.UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog =Transport.Data");
            .UseSqlServer("Data Source = JORGEBERMUDEZ\\SQLEXPRESS; Initial Catalog = Transport.Data ;persist security info=True;user id=sa;password=1234;multipleactiveresultsets=True;");
            //.UseSqlServer("Data Source = DESKTOP-QV0AIMJ\\SQLEXPRESS; Initial Catalog = Transport.Data ;persist security info=True;user id=sa;password=1234;multipleactiveresultsets=True;");
        }
    }
}