

namespace PizzaBox.Client
{
  public class Startup
  {
    // Called by runtime, add services to container
    // 
    public void ConfigureServices(IServicesCollection services)
    {
      services.AddControllersWithViews();
      services.AddScoped<UnitOfWork>();
    } 

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseRouting();
      
      app.UseEndpoints(endpoints => 
      {
        endpoints.MapControllers();
      });
    }
  }
}