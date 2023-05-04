using Microsoft.EntityFrameworkCore;
using Pustok.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlServer("Server=Elfrustaichi\\SQLEXPRESS;Database=PustokProject;Trusted_Connection=true");
});

var app = builder.Build();

app.UseAuthorization();

app.UseRouting();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute("default",
    "{controller=home}/{action=index}/{id?}"
    );

app.Run();