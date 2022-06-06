using MoviWebApi.Models;
using MoviWebApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<CarStoreDatabaseSettings>(
    builder.Configuration.GetSection("CarStoreDatabase"));

builder.Services.AddSingleton<CarsService>();

builder.Services.AddControllers()
    .AddJsonOptions(
        options => options.JsonSerializerOptions.PropertyNamingPolicy = null);

// Add services to the container.

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
