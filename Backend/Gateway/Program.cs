using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json");
//adding as a service
builder.Services.AddOcelot();
var app = builder.Build();

//adding as a middleware
app.UseOcelot().Wait();
app.MapControllers();

app.Run();
