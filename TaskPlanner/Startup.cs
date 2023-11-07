using TaskPlanner.Models.Entities;
using TaskPlanner.Models.Interfaces;

namespace TaskPlanner
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc(options => options.EnableEndpointRouting = false);
            services.AddScoped<IStorage, Storage>();
            services.AddRazorPages();
            

        }

        public void Configure(IApplicationBuilder applicationBuilder)
        {
            
            applicationBuilder.UseStaticFiles();
            applicationBuilder.UseMvc(
              configureRoutes =>
              {
                  configureRoutes.MapRoute("Index", string.Empty, new { controller = "Home", action = "Index" });
              }
            );
            
        }
    }
}
