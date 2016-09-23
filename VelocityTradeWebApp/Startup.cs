using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VelocityTradeWebApp.Startup))]
namespace VelocityTradeWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
