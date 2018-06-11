using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VezbiJuniIspit.Startup))]
namespace VezbiJuniIspit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
