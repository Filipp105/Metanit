var builder = WebApplication.CreateBuilder();
builder.Logging.ClearProviders();   // удаляем все провайдеры
builder.Logging.AddConsole();   // добавляем провайдер для логгирования на консоль
var app = builder.Build();