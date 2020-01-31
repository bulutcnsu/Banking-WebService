using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TakipWeb.Web.Startup))]
namespace TakipWeb.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
