using Insfraestrutura.Configuracoes;
using Microsoft.EntityFrameworkCore;
using Dominio.Interfaces.Genericos;
using Insfraestrutura.Repositorio.Genericos;
using Dominio.Interfaces;
using Insfraestrutura.Repositorio;
using Dominio.Interfaces.InterfaceServicos;
using Dominio.Servicos;
using Entidades.Entidades;
using Aplicacao.Interfaces;
using Aplicacao.Aplicacoes;

var builder = WebApplication.CreateBuilder(args);


// Recupera a string de conex�o do appsettings.json
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Adiciona o DbContext ao cont�iner de servi�os
builder.Services.AddDbContext<Contexto>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false).AddEntityFrameworkStores<Contexto>();

// interface e repositorio
builder.Services.AddSingleton(typeof(IGenericos<>), typeof(RepositorioGenerico<>));
builder.Services.AddSingleton(typeof(INoticia), typeof(RepositorioNoticia));
builder.Services.AddSingleton(typeof(IUsuario), typeof(RepositorioUsuario));

// servi�o dominio
builder.Services.AddSingleton<IServicoNoticia, ServicoNoticia>();

// interface aplica��o
builder.Services.AddSingleton<IAplicacaoNoticia, AplicacaoNoticia>();
builder.Services.AddSingleton<IAplicacaoUsuario, AplicacaoUsuario>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
