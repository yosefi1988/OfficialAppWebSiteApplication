using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficialAppWebSiteApplication.Startup))]
namespace OfficialAppWebSiteApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
