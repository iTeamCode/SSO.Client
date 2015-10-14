using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp.Teacher.Startup))]
namespace WebApp.Teacher
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
