var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
int a = 10;

app.MapGet("/", GetResult);

string GetResult()
{
  return "Hello World"; 
}

app.Run();
