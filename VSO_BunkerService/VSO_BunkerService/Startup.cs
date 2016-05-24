using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VSO_BunkerService.Startup))]
namespace VSO_BunkerService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
