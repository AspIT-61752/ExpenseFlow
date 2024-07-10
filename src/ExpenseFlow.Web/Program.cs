using ExpenseFlow.Context;
using ExpenseFlow.Entity;
using ExpenseFlow.Web.Components;

namespace ExpenseFlow.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddScoped(sp => new HttpClient
            {
                // Should get the base address from the configuration (appsettings.json), should be https://localhost:7023/api/ 
                //BaseAddress = new Uri(builder.Configuration["API:BaseUrl"] ?? "https://localhost:7023/api/")
                BaseAddress = new Uri(@"https://localhost:7023/api/")
            });

            builder.Services.AddHttpClient<IRepository<User>, Repository<User>>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}
