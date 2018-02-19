using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPnetWebApp.Startup))]
namespace ASPnetWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
