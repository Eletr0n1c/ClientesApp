using ClientesApp.API.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//adicionando a classe de configuração do AutoMapper
builder.Services.AddAutoMapper(typeof(ProfileMapping));

//adicionando as políticas de CORS
builder.Services.AddCors(
    config => config.AddPolicy("DefaultPolicy", builder => {
        
        builder.WithOrigins("http://localhost:4200")
                  .AllowAnyMethod()
                  .AllowAnyHeader();

    })
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//registrando a política CORS
app.UseCors("DefaultPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
