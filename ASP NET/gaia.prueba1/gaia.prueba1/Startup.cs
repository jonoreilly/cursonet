using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gaia.prueba1.Startup))]
namespace gaia.prueba1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
