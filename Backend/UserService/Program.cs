using UserService.Clients;
using Polly;
using Polly.Timeout;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Random jitterer = new Random();
builder.Services.AddHttpClient<DestinationsClient>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7178");
})//added for exponential retries
    .AddTransientHttpErrorPolicy(builder=>builder.Or<TimeoutRejectedException>().WaitAndRetryAsync(
    5,
    retryAttempt=>TimeSpan.FromSeconds(Math.Pow(2,retryAttempt))
    +TimeSpan.FromSeconds(jitterer.Next())))
    //added a policy to wait for the dependent client for only one second
    .AddPolicyHandler(Policy.TimeoutAsync<HttpResponseMessage>(1));

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
