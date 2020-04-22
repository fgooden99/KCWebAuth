using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KCWebAuth.Startup))]
namespace KCWebAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
