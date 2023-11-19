var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
int a = 10;

app.MapGet("/", () => "Hello World!" + a);

app.Run();
