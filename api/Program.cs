using api.Data;
using api.Interfaces;
using api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddControllers();   //manually added lines
builder.Services.AddControllers().AddNewtonsoftJson(options => {
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
});  // Manually added lines
builder.Services.AddDbContext<ApplicationDBContext>(options => {     //manually added lines
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));  //manually added lines
});

builder.Services.AddScoped<IStockRepository, StockRepository>();   //manually added lines
builder.Services.AddScoped<ICommentRepository, CommentRepository>(); //manually added lines

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();   //manually added line
 
app.Run();