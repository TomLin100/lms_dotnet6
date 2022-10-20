using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using LMSweb.Models;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration["LMSweb"];

builder.Services.AddDbContext<LMSmodel>(options=>{
    options.UseSqlServer(conn);
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
.AddCookie(option=>{
    option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    option.ClaimsIssuer = "Teacher";
    option.LoginPath = new PathString("/Teacher/Login");
})
.AddCookie(option=>{
    option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
    option.ClaimsIssuer = "Student";
    option.LoginPath = new PathString("/Student/Login");
});
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
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.UseRouting();
app.UseHttpsRedirection();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
