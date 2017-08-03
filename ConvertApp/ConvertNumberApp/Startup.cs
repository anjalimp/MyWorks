using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConvertNumberApp.Startup))]
namespace ConvertNumberApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
