using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SSO.Client.Startup))]
namespace SSO.Client
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
