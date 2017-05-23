using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaAspNet.Startup))]
namespace PruebaAspNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
