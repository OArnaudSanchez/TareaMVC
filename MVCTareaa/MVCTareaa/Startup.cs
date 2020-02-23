using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCTareaa.Startup))]
namespace MVCTareaa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
