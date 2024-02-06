var builder = WebApplication.CreateBuilder();
var app = builder.Build();

// отправляем html-код при обращении по пути "/"
app.Map("/", () => Results.Extensions.Html(@"<!DOCTYPE html>
<html>
<head>
<title>METANIT.COM</title>
<meta charset='utf-8' />
</head>
<body>
<h1>Hello METANIT.COM</h1>
</body>
</html>
"));

app.Run();

class HtmlResult : IResult
{
    string htmlCode = "";
    public HtmlResult(string htmlCode) => this.htmlCode = htmlCode;

    public async Task ExecuteAsync(HttpContext context)
    {
        context.Response.ContentType = "text/html; charset=utf-8";
        await context.Response.WriteAsync(htmlCode);
    }
}

static class ResultsHtmlExtension
{
    public static IResult Html(this IResultExtensions ext, string htmlCode) => new HtmlResult(htmlCode);
}