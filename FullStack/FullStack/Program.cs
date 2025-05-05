


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
var app = builder.Build();
builder.Services.AddSingleton<IApartment, Apartment>();
app.MapGet("/", () => "Hello World!");
app.MapControllers();
app.Run();
