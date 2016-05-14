using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ticketsManager.Startup))]
namespace ticketsManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
