using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DEX.Startup))]
namespace DEX
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
