using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHybridSite1.Startup))]
namespace MyHybridSite1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
