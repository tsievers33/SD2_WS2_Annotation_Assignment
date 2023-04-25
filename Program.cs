using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SD2_WS2_Annotation_Assignment.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SD2_WS2_Annotation_AssignmentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SD2_WS2_Annotation_AssignmentContext") ?? throw new InvalidOperationException("Connection string 'SD2_WS2_Annotation_AssignmentContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
