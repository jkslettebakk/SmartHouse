using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Http.Abstractions;
using Blazorise;
using Blazorise.Charts;
using Blazorise.Utils;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace TemperatureClient
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebAssemblyHostBuilder CreateHostBuilder(string[] args) =>
            BlazorWebAssemblyHost.CreateDefaultBuilder()
                .UseBlazorStartup<Startup>();

        private static void RegisterComponents(IComponentMapper componentMapper)
        {
            componentMapper.Register<Blazorise.Addon, Blazorise.Bootstrap.Addon>();
            componentMapper.Register<Blazorise.BarToggler, Blazorise.Bootstrap.BarToggler>();
            componentMapper.Register<Blazorise.BarDropdown, Blazorise.Bootstrap.BarDropdown>();
            componentMapper.Register<Blazorise.CardSubtitle, Blazorise.Bootstrap.CardSubtitle>();
            componentMapper.Register<Blazorise.CloseButton, Blazorise.Bootstrap.CloseButton>();
            componentMapper.Register<Blazorise.CheckEdit, Blazorise.Bootstrap.CheckEdit>();
            componentMapper.Register<Blazorise.Field, Blazorise.Bootstrap.Field>();
            componentMapper.Register<Blazorise.FieldBody, Blazorise.Bootstrap.FieldBody>();
            componentMapper.Register<Blazorise.FileEdit, Blazorise.Bootstrap.FileEdit>();
            componentMapper.Register<Blazorise.ModalContent, Blazorise.Bootstrap.ModalContent>();
        }

        public static IApplicationBuilder UseBootstrapProviders(this IApplicationBuilder app)
        {
            var componentMapper = app.ApplicationServices.GetRequiredService<IComponentMapper>();

            RegisterComponents(componentMapper);

            return app;
        }

    }
}
