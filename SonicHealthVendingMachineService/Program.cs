using SonicHealthVendingMachineService.Infrastructure;
using SonicHealthVendingMachineService.Services;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMemoryCache();
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
                          policy =>
                          {
                              policy.WithOrigins("http://localhost:4200",
                                                  "https://localhost:4200")
                                                  .AllowAnyHeader()
                                                  .AllowAnyMethod();
                          });
});
builder.Services.AddScoped<CanDrinkService>();
builder.Services.AddScoped<ICacheService, CacheService>();
builder.Services.AddScoped<ICacheProvider, CacheProvider>();
builder.Services.AddScoped<ICanDrinkService, CanDrinkService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(MyAllowSpecificOrigins);
//app.UseCors(
//        options => options.WithOrigins("http://localhost:4200").AllowAnyMethod()
//    );

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

