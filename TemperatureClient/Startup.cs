using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;
using WebCore.Data;
using Blazorise;
using Blazorise.Charts;
using Blazorise.Utils;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace TemperatureClient
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
              .AddBlazorise(options =>
              {
                  options.ChangeTextOnKeyPress = true; // optional
              })
              .AddBootstrapProviders()
              .AddFontAwesomeIcons();
        }
        public void Configure(IComponentsApplicationBuilder app)
        {
            app.Services
              .UseBootstrapProviders()
              .UseFontAwesomeIcons();

            app.AddComponent<App>("app");
        }

    }
}
