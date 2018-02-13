using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(patata.Startup))]
namespace patata
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
