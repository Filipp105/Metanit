var builder = WebApplication.CreateBuilder();
builder.Logging.ClearProviders();   // ������� ��� ����������
builder.Logging.AddConsole();   // ��������� ��������� ��� ������������ �� �������
var app = builder.Build();