using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gaia.webforms.test.Startup))]
namespace gaia.webforms.test
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
