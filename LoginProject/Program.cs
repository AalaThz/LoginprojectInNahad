﻿using LoginProjectCore.Services;
using LoginProjectDomain.Interfaces.IRepositories;
using LoginProjectDomain.Interfaces.IServices;
using LoginProjectInfrastructure.Repositories;
using LoginProjectInfrastructure.Repositories.Interface;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//var connetionString = builder.Configuration.GetConnectionString("Login");
//builder.Services.AddDbContext<LoginProjectInfrastructure.Contexts.DbContext>(c => c.UseSqlServer(connetionString));  

var connetionString = builder.Configuration.GetConnectionString("LoginLocal");
builder.Services.AddDbContext<LoginProjectInfrastructure.Contexts.MyContext>(c => c.UseSqlServer(connetionString));

#region DI

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ITrafficHostInfoRepository, TrafficHostInfoRepository>();
builder.Services.AddScoped<IReasonChoiceRepository, ReasonChoiceRepository>();
builder.Services.AddScoped<ILatestNewsRepository, LatestNewsRepository>();

builder.Services.AddScoped<BaseRepository>();

//------------------------------------Services------------------------------------
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IReasonChoiceService, ReasonChoiceService>();
builder.Services.AddScoped<ILatestNewsService, LatestNewsService>();
builder.Services.AddScoped<ITrafficHostInfoService, TrafficHostInfoService>();

#endregion


#region forLogin
//برای احراز هویت
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = "/Login";
    options.LogoutPath = "/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
});
#endregion


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
//pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");
pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();
