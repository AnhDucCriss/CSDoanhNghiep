using DuAn2.Data;
using DuAn2.Interface;
using DuAn2.Repositories;
using Microsoft.EntityFrameworkCore;

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




builder.Services.AddScoped<IGiaoVien, GiaoVienRepository>();
builder.Services.AddScoped<IHocVien, HocVienRepository>();
builder.Services.AddScoped<ILichDay, LichDayRepository>();
builder.Services.AddScoped<IMonHoc, MonHocRepository>();
builder.Services.AddScoped<ILopHoc, LopHocRepository>();
builder.Services.AddScoped<ITKB, TKBReposittory>();




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
