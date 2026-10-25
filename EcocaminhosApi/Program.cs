using EcocaminhosApi.Interfaces;
using EcocaminhosApi.Repositories;
using EcocaminhosApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddScoped<ICasaRepository, CasaRepository>();
builder.Services.AddScoped<ISituacaoRepository, SituacaoRepository>();
builder.Services.AddScoped<IQuartoRepository, QuartoRepository>();
builder.Services.AddScoped<ITipoProgramaRepository, TipoProgramaRepository>();
builder.Services.AddScoped<IVoluntarioRepository, VoluntarioRepository>();

builder.Services.AddControllers().AddJsonOptions(o =>
    o.JsonSerializerOptions.ReferenceHandler =
        System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles);

builder.Services.AddOpenApi();

builder.Services.AddCors(options =>
{
    options.AddPolicy("front", policy =>
        policy.WithOrigins("http://localhost:5173", "http://127.0.0.1:5500")
              .AllowAnyHeader()
              .AllowAnyMethod());
});
var app = builder.Build();
app.UseCors("front");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
