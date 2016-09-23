using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ValidadorWeb.Startup))]
namespace ValidadorWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
