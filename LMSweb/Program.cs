using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using LMSweb.Models;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);

// var conn = builder.Configuration["LMSweb"];

builder.Services.AddDbContext<LMSmodel>();

builder.Services.AddAuthentication();

builder.Services.AddAuthentication(op => {
    op.DefaultScheme = "Student";
})
.AddCookie("Student", option =>
{
    option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    option.LoginPath = new PathString("/Student/Login");
    option.Cookie.HttpOnly = true;
    option.Cookie.SameSite = SameSiteMode.Strict;
});
builder.Services.AddAuthentication(op => {
    op.DefaultScheme = "Teacher";
})
.AddCookie("Teacher", option =>
{
    option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    option.LoginPath = new PathString("/Teacher/Login");
    option.Cookie.HttpOnly = true;
    option.Cookie.SameSite = SameSiteMode.Strict;
});
builder.Services.AddAuthorization();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, 
    //see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
