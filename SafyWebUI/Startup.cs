using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SafyWebUI.Startup))]
namespace SafyWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
