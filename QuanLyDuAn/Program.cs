using Microsoft.EntityFrameworkCore;
using QuanLyDuAn.Data;
using QuanLyDuAn.Repositories;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod()));

builder.Services.AddDbContext<WebContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("Web"));
});

builder.Services.AddScoped<IDungCuRepository, DungCuRepository>();
builder.Services.AddScoped<IPhongHocRepository, PhongHocRepository>();
builder.Services.AddScoped<IMonHocRepository, MonHocRepository>();
builder.Services.AddScoped<ITrinhDoRepository, TrinhDoRepository>();
builder.Services.AddScoped<IGiaoVienRepository, GiaoVienRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
