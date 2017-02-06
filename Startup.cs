using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5InternetApp.Startup))]
namespace MVC5InternetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
