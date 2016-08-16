using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BSC.Trio.WebApp.Startup))]
namespace BSC.Trio.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
