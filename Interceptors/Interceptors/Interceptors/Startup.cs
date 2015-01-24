using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Interceptors.Startup))]
namespace Interceptors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
