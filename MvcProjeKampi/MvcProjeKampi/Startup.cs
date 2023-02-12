using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcProjeKampi.Startup))]
namespace MvcProjeKampi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
