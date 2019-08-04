using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReachOutApp.Startup))]
namespace ReachOutApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
