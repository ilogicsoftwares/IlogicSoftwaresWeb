using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IlogicSoftwaresWeb.Startup))]
namespace IlogicSoftwaresWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
