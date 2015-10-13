using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp.LaunchPad.Startup))]
namespace WebApp.LaunchPad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
