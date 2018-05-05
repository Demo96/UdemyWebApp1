using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UdemyWebApp1.Startup))]
namespace UdemyWebApp1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
