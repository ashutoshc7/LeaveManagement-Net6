using LeaveManagementWeb.Configurations;
using LeaveManagementWeb.Contracts;
using LeaveManagementWeb.Data;
using LeaveManagementWeb.Repositories;
using LeaveManagementWeb.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");//creating the connection string (get connection string by the name default connection)
builder.Services.AddDbContext<ApplicationDbContext>(options =>  //Initializing that the dbcontext should be added to the service wrapper
    options.UseSqlServer(connectionString));//Get the dbcontext relative to that bridge using connection string as found in the configuration
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<Employee>(options => options.SignIn.RequireConfirmedAccount = true)//Everything identity related should be related to class Employee
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddTransient<IEmailSender>(s => new EmailSender("localHost", 25, "no-reply@leavemanagement.com"));//AddTransient-because we want new instance of email sender each time

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<ILeaveTypeRepository,LeaveTypeRepository>();
builder.Services.AddScoped<ILeaveAllocationRepository,LeaveAllocationRepository>();

builder.Services.AddAutoMapper(typeof(MapperConfig));
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

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
