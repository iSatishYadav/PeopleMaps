using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PeopleMaps.Startup))]
namespace PeopleMaps
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
