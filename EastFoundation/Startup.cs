using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EastFoundation.Startup))]
namespace EastFoundation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
