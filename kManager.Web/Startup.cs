using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kManager.Web.Startup))]
namespace kManager.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
