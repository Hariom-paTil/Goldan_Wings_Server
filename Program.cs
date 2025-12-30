using Microsoft.EntityFrameworkCore;
using UserLogin;
using UserLogin.Admin.Service;
using UserLogin.Mapping;
using UserLogin.Repo_Pattern;
using UserLogin.Service;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add controllers
builder.Services.AddControllers();

// ✅ Add Swagger services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ✅ Database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IUserLoginService, UserLoginService>();
builder.Services.AddScoped<IAdminLoginService, AdminLoginService>();
builder.Services.AddScoped<IOrderService, OrderService>();


// ✅ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

var app = builder.Build();

// ✅ Enable Swagger only in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngular");

app.UseAuthorization();

app.MapControllers();

app.Run();