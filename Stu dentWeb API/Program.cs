using FluentValidation.AspNetCore;
using Stu_dentWeb_API.Filters;
using StudentSERVİCE.Extension;
using StudentSERVİCE.Validations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
 
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRegistration();

builder.Services.AddControllers(options => { options.Filters.Add<ValidationFilter>(); })
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining(typeof(StudentValidation)))
    .ConfigureApiBehaviorOptions(o => o.SuppressModelStateInvalidFilter = true);

var app = builder.Build();
app.UseHttpLogging();



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
