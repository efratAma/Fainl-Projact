using BL.Api;
using BL.Services;
using DAL.Api;
using DAL.Services;
using FullStack.api;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var relativeDbPath = Path.Combine("..", "..", "..", "..", "DAL", "Data", "dataBase.mdf");
var fullDbPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativeDbPath));

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!
    .Replace("PATH_TO_REPLACE", fullDbPath);

builder.Services.AddDbContext<dbClass>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IInvesterServiceBl, InvesterServiceBl>();
builder.Services.AddScoped<IInvesterDal, InvesterServiceDal>(); // הוספת השירות

builder.Services.AddScoped<IApartmentDal, ApartmentServiceDal>();
builder.Services.AddScoped<IApartmentServiceBl, ApartmentServiceBl>();

builder.Services.AddScoped<IProjectDal, ProjectServiceDal>();
builder.Services.AddScoped<IProjectServiceBl, ProjectServiceBl>();



//builder.Services.AddControllers();


//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowReact", policy =>
//    {
//        policy.WithOrigins("http://localhost:3000") 
//              .AllowAnyHeader()
//              .AllowAnyMethod();
//    });
//});



//var app = builder.Build();

//app.UseDefaultFiles();
//app.UseStaticFiles();
////app.UseSpa(spa =>
////{
////    spa.Options.SourcePath = "ClientApp";

////    if (env.IsDevelopment())
////    {
////        spa.UseReactDevelopmentServer(npmScript: "start");
////    }
////});
//app.UseCors("AllowReact");


//app.MapControllers();
//app.MapGet("/", () => "Hello World!");

//app.Run();

// 1. הוספת CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
    {
        policy.WithOrigins("http://localhost:3000", "https://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddControllers();

var app = builder.Build();

// 2. הפעלת CORS — צריך להיות **לפני MapControllers**
app.UseCors("AllowReact");

app.UseAuthorization();

app.MapControllers();

app.Run();
