using NLog.Web;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.SetMinimumLevel(LogLevel.Information);
}).UseNLog();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Test",
        policy =>
        {
            policy.WithOrigins("http://localhost:3000", 
                                "http://localhost")
                                .AllowAnyHeader()
                                .AllowAnyMethod();
        });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("Test");

app.UseAuthorization();

app.MapControllers();

app.Run();