using BL.Api;
using BL.Services;
using DAL.Api;
using DAL.Services;
using FullStack.api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddDbContext<dbClass>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IInvesterServiceBl, InvesterServiceBl>();
builder.Services.AddScoped<IInvesterDal, InvesterServiceDal>(); // הוספת השירות

builder.Services.AddScoped<IApartmentDal, ApartmentServiceDal>();
builder.Services.AddScoped<IApartmentServiceBl, ApartmentServiceBl>();




builder.Services.AddSingleton<dbClass>(provider => new dbClass(/* פרמטרים אם יש צורך */));
builder.Services.AddControllers();




var app = builder.Build();


app.MapControllers();
app.MapGet("/", () => "Hello World!");

app.Run();