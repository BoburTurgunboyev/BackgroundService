using BackGroundSevices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<HostOptions>(options =>
{
    
});

builder.Services.AddHostedService<ExampleService>();

var app = builder.Build();


app.Run();
