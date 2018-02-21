using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Carlsuns.WebConsole.Startup))]
namespace Carlsuns.WebConsole
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
