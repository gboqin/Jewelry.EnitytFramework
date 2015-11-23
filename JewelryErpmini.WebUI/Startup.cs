using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JewelryErpmini.WebUI.Startup))]
namespace JewelryErpmini.WebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
