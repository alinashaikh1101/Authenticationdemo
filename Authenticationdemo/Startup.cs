using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Authenticationdemo.Startup))]
namespace Authenticationdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
