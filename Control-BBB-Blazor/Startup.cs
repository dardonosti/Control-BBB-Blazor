using Blazored.LocalStorage;
using Control_BBB_Blazor.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Sotsera.Blazor.Toaster.Core.Models;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace Control_BBB_Blazor
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddRazorPages();
      services.AddServerSideBlazor();
      services.AddBlazoredLocalStorage();
      services.AddHttpClient();
      services
      .AddBlazorise(options =>
       {
         options.ChangeTextOnKeyPress = true; // optional
       })
      .AddBootstrapProviders()
      .AddFontAwesomeIcons();

      // Add the library to the DI system
      services.AddToaster(config =>
      {
        //example customizations
        config.PositionClass = Defaults.Classes.Position.TopRight;
        config.PreventDuplicates = true;
        config.NewestOnTop = false;
        config.ShowTransitionDuration = 1000;
        config.VisibleStateDuration = 5000;
        config.HideTransitionDuration = 2000;
        config.MaximumOpacity = 90;
        config.MaxDisplayedToasts = 5;
        config.PreventDuplicates = false;
      });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }
      else
      {
        app.UseExceptionHandler("/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();
      }

      app.UseHttpsRedirection();
      app.UseStaticFiles();

      app.UseRouting();

      app.ApplicationServices
      .UseBootstrapProviders()
      .UseFontAwesomeIcons();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapBlazorHub();
        endpoints.MapFallbackToPage("/_Host");
      });
    }
  }
}
