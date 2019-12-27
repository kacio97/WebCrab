using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeCrab.Startup))]
namespace WeCrab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
