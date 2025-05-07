using BL.Api;
using DAL.Api;
using FullStack.api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ����� ����� �� dbClass
builder.Services.AddDbContext<dbClass>(options =>
    options.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\������ ����\\Data\\dataBase.mdf;Integrated Security=True;Connect Timeout=30"));

builder.Services.AddSingleton<IApartmentDal, ApartmentServiceDal>();
builder.Services.AddSingleton<IApartmentServiceBl, ApartmentServiceBl>();
builder.Services.AddSingleton<dbClass>(provider => new dbClass(/* ������� �� �� ���� */));
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();