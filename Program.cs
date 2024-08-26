using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TransportManagement.Data;
using TransportManagement.Errors;
using TransportManagement.Infrastructure;
using TransportManagement.Interface;
using TransportManagement.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TransportContext>(opt =>
{
    opt.UseSqlServer(
        builder.Configuration.GetConnectionString("TransportConnectString"),
        options => options.CommandTimeout(4500)
    );
});
builder.Services.AddScoped(typeof(ICustomerService), typeof(CustomerService));
builder.Services.AddScoped(typeof(IDriverUserService), typeof(DriverUserService));
builder.Services.AddScoped(typeof(ITruckService), typeof(TruckService));
builder.Services.AddScoped(typeof(IUnitManagementService), typeof(UnitManagementService));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.Configure<ApiBehaviorOptions>(options =>
{
    options.InvalidModelStateResponseFactory = actionContext =>
    {
        var errors = actionContext.ModelState
        .Where(e => e.Value?.Errors.Count > 0)
        .SelectMany(x => x.Value!.Errors)
        .Select(x => x.ErrorMessage).ToArray();
        var errorResponse = new ApiValidationErrorResponse
        {
            Errors = errors
        };
        return new BadRequestObjectResult(errorResponse);
    };
});

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", policy =>
    {
        policy.WithOrigins("https://localhost:4200").AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });
});
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();
var urlOrigins = new[]
{
    "http://localhost:5000",
    "https://localhost:5001"
};
app.UseCors(opt =>
{
    opt.AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials()
        .WithOrigins(urlOrigins);
});

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;
var context = scope.ServiceProvider.GetRequiredService<TransportContext>();
var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();
try
{
    await context.Database.MigrateAsync();
    await TransportManagementContextSeed.SeedAsync(context);
}
catch (Exception ex)
{
    logger.LogError(ex, "Có lỗi xảy ra khi Migrate");
}

app.Run();
