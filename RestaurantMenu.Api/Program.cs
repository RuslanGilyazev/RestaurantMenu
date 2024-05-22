using RestaurantMenu.Api.Extensions;
using RestaurantMenu.Api.Filters;
using RestaurantMenu.Api.Validations.Extensions;
using RestaurantMenu.Database.Memory.Extensions;
using RestaurantMenu.Services.Extensions;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApiVersioning(options => options.ReportApiVersions = true).Services
    .ConfigureApiMapping()
    .AddControllers(options => 
        options.Filters.Add<NotFoundExceptionFilter>()).Services
    .AddRestaurantApiValidators()
    .AddSwaggerGen()
    .AddRestaurantServices()
    .AddRestaurantMemoryDatabaseServices()
    .AddSerilog();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.UseHttpsRedirection();
app.UseSerilogRequestLogging();

app.Run();