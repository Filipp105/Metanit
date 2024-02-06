using Chapter_8._3.Properties;

var builder = WebApplication.CreateBuilder();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();

var app = builder.Build();

app.UseSession();

app.Run(async (context) =>
{
    if (context.Session.Keys.Contains("person"))
    {
        Person? person = context.Session.Get<Person>("person");
        await context.Response.WriteAsync($"Hello {person?.Name}, your age: {person?.Age}!");
    }
    else
    {
        Person person = new Person { Name = "Tom", Age = 22 };
        context.Session.Set<Person>("person", person);
        await context.Response.WriteAsync("Hello World!");
    }
});

app.Run();