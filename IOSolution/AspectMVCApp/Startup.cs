using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspectMVCApp.Startup))]
namespace AspectMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
