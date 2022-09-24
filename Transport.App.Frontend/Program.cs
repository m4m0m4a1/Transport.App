using Transport.App.Persistencia.AppRepositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IRepositorioTipoVehiculo, RepositorioTipoVehiculo>();
builder.Services.AddSingleton<IRepositorioVehiculo, RepositorioVehiculo>();
builder.Services.AddSingleton<IRepositorioSeguro, RepositorioSeguro>();
builder.Services.AddSingleton<IRepositorioTipoSeguro, RepositorioTipoSeguro>();
builder.Services.AddSingleton<IRepositorioPersona, RepositorioPersona>();
builder.Services.AddSingleton<IRepositorioTipoIdentificacion, RepositorioTipoIdentificacion>();
builder.Services.AddSingleton<IRepositorioGenero, RepositorioGenero>();
builder.Services.AddSingleton<IRepositorioRol, RepositorioRol>();
builder.Services.AddSingleton<IRepositorioNivelEstudio, RepositorioNivelEstudio>();
builder.Services.AddSingleton<IRepositorioRevision, RepositorioRevision>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
