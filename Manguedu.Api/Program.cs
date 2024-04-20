using Manguedu.Domain;
using Manguedu.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Manguedu.Api;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        builder.Services.AddIdentity<UsuarioApp, IdentityRole>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
        }).AddEntityFrameworkStores<ApplicationDbContext>();


        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            var connString = builder.Configuration.GetConnectionString("Database");

            options.UseNpgsql(connString, npgsqlOptionsAction =>
            {
                npgsqlOptionsAction.CommandTimeout(30);
                npgsqlOptionsAction.EnableRetryOnFailure(3);
            });

            if (builder.Environment.IsDevelopment())
            {
                options.EnableDetailedErrors(true);
                options.EnableSensitiveDataLogging(true);
            }
        });

        var app = builder.Build();

        //Aplica as migrações faltantes
        //TODO: Como eu vou lidar com isso num ambiente de produção?
        using(var scope = app.Services.CreateScope())
        {
            var services = scope.ServiceProvider;
            var context = services.GetRequiredService<ApplicationDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
        }

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
            app.UseHttpsRedirection();
        }

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        using (var scope = app.Services.CreateScope())
        {
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var roles = Enum.GetNames(typeof(Roles));

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        app.Run();
    }
}
