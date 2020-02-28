using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ErrorHandlingMVC.Startup))]
namespace ErrorHandlingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
