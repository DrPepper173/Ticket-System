using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoEvents.Startup))]
namespace GoEvents
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
