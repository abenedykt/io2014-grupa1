using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Aspekty.Startup))]
namespace Aspekty
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
