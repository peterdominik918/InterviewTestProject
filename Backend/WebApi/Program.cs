using DEmployee.ApplicationLayer.Employees;
using DEmployee.InfrastructureLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

EmployeeRepository repository = new EmployeeRepository();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IEmployeeService, EmployeeService>(f => new EmployeeService(repository));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Origins", policy =>
    {
        policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Origins");

app.UseAuthorization();

app.MapControllers();

app.Run();
