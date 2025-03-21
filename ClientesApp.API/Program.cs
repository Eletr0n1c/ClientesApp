using ClientesApp.API.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(config => { config.LowercaseUrls = true; });
SwaggerConfiguration.AddSwaggerConfiguration(builder.Services);
DependencyInjectionConfiguration.AddDependencyInjection(builder.Services);

var app = builder.Build();

SwaggerConfiguration.UseSwaggerConfiguration(app);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
