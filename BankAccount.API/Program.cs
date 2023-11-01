using BankAccount.Context;
using BankAccount.Repository.Interfecaes;
using BankAccount.Repository.Repository;
using BankAccount.Services.Intefaces;
using BankAccount.Services.Services;
using Microsoft.EntityFrameworkCore;
using MyProject.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(option => option.AddPolicy("corsPolicy", builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader()));

//builder.Services.AddServices();
builder.Services.AddDbContext<MyDbContext>();
builder.Services.AddDbContext<IContext, MyDbContext>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAccountTypeService, AccountTypeService>();
builder.Services.AddScoped<IAccountTypeRepository, AccountTypeRepository>();
builder.Services.AddScoped<IAccountOfUserRepository, AccountOfUserRepository>();
builder.Services.AddScoped<IAccountOfUserService, AccountOfUserService>();
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddAutoMapper(typeof(Mapping));

//builder.Services.AddDbContext<IContext, MyDbContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors("corsPolicy");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();