using JwtBearer.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<TokenService>();

var app = builder.Build();

app.MapGet("/", (TokenService service) =>
    service.Generate(new(1, "daniel.bezerra.mult@outlook.com", "1234", ["Student, Free"])));

app.Run();
