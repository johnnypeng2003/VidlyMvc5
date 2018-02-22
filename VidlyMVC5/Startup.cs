using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMVC5.Startup))]
namespace VidlyMVC5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
