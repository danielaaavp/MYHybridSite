using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MYHybridSite.Startup))]
namespace MYHybridSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
