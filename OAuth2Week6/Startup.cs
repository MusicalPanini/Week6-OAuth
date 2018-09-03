using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OAuth2Week6.Startup))]
namespace OAuth2Week6
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
