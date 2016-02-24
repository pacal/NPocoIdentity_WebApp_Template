using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NPocoIdentityWebAppTemplate.Startup))]
namespace NPocoIdentityWebAppTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
