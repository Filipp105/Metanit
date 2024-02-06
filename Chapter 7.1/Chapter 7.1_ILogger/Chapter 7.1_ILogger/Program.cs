var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Run(async (context) =>
{
    var path = context.Request.Path;
    app.Logger.LogCritical($"LogCritical {path}");
    app.Logger.LogError($"LogError {path}");
    app.Logger.LogInformation($"LogInformation {path}");
    app.Logger.LogWarning($"LogWarning {path}");

    await context.Response.WriteAsync("Hello World!");
});

app.Run();
