using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaBox.Storage;

namespace PizzaBox.Client
{
  public class Startup
  {
    // Called by runtime, add services to container
    // 
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllersWithViews();
      services.AddScoped<UnitOfWork>();
      // Add_ (instance per lifetime)
      // scoped(instance per session), each get so wait on yourselves. same instance for your visit
      // singleton(instance per application) best on readonly, else cause traffic
      // transient(instance per request), Overkill esp if 100 ppl w/ 10 request each
      services.AddDbContext<PizzaBoxContext>(ParallelOptions =>
      {
        options.UseNpgsql(_configuration["pgsql"]);
        options.UseNpgsql(Configuration.GetConnectionString(""));
      });
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