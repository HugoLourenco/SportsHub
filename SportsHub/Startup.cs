using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SportsHub.Startup))]
namespace SportsHub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
