using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoreFirstPrimary.Startup))]
namespace CoreFirstPrimary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
